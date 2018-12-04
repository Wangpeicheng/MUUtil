#!/usr/bin/python
# -*- coding:utf-8 -*-

import os
import os.path
import sys
import time
import datetime
import stat
import difflib
import linecache, shutil
import codecs
import hashlib

import pro_conf

reload(sys)
sys.setdefaultencoding("utf-8")

global_file_name = ('out_server.txt','out_client.txt')

def if_exist(outtype):
    # 判断文件out.txt是否存在,不存在则创建
    filename = global_file_name[outtype]
    
    if os.path.exists(filename):
        message = ' the "%s" file exists.'
    else:
        message = " cannot find the '%s' file.. create it."
        a = open(filename, 'w')
        a.close()
    print message % filename

def get_md5_01(file_path):  #小文件
    md5 = None
    if os.path.isfile(file_path):
        f = open(file_path,'rb')
        md5_obj = hashlib.md5()
        md5_obj.update(f.read())
        hash_code = md5_obj.hexdigest()
        f.close()
        md5 = str(hash_code).lower()
    return md5

def log_compare(path,file_list,changeFiles,outtype,pro_conf):

    # 先确保out.txt存在
    if_exist(outtype)

    # 获取out.txt文件内容（文件全路径key和最后修改时间value），生成dict
    txt = codecs.open(global_file_name[outtype], 'r','utf-8').readlines()
    myDic = {}
    for row in txt:
        (key, value) = row.split(',')
        myDic[key] = value
    #print myDic

    #因为conf文件的提交时间（如策划先提交表，程序后提交conf）可能跟其他不一样。。。所以conf有改需全部重新生成
    pro_conf_change = False
    time = get_md5_01(pro_conf)
    file_time = '%s\n' % time                                      
    if myDic.has_key(pro_conf) == True:
        if cmp(myDic[pro_conf], file_time):                  
            pro_conf_change = True
    else:
        pro_conf_change = True

    #判断key，比较value值是否变化
    #原始需要有一个out.txt文件，才能比较value确定是否有更新
    #运行程序时，重新遍历一遍文件全路径和最后修改时间
    for name in file_list:
        temp_path = os.path.join(path,name.xls_file)
        file_name = os.path.join(path,name.xls_file)
        #time = os.stat(temp_path).st_mtime                              # 获取最后修改时间
        time = get_md5_01(temp_path)
        file_time = '%s\n' % time                                       # 加%s\n是为了与out.txt里值完全对应
        if myDic.has_key(temp_path) == True:
            if pro_conf_change == True or cmp(myDic[temp_path], file_time):        # myDic[file_name]旧最后修改时间，file_time新最后修改时间
                #print (file_name,file_time)             # 输出有变化的文件名及其对应的最后修改时间
                changeFiles.append(temp_path)
        else:
            #print (file_name,file_time)
            changeFiles.append(temp_path)
    #for root , dirs, files in os.walk(path):
        


def add_log(path,file_list,outtype,pro_conf):
    with open(global_file_name[outtype],'w') as f:
        f.close()
    
    file_time = get_md5_01(pro_conf)
    with codecs.open(global_file_name[outtype],'a','utf-8') as f:
        f.write( ','.join( ['%s' % pro_conf , '%s\n' % file_time] ) )
        f.close()
    for name in file_list:
        file_name = os.path.join(path,name.xls_file)
        #file_time = os.stat(file_name).st_mtime #修改时间
        file_time = get_md5_01(file_name)
        with codecs.open(global_file_name[outtype],'a','utf-8') as f:
            f.write( ','.join( ['%s' % file_name , '%s\n' % file_time] ) )
            f.close()
    """
    for root , dirs, files in os.walk(path):
        for name in files:
            temp_path = os.path.join(path,name.decode('gbk'))
            file_time = os.stat(temp_path).st_mtime
            with codecs.open('out.txt','a','utf-8') as f:
                f.write( ','.join( ['%s' % temp_path , '%s\n' % file_time] ) )
                f.close()
    """
    


if __name__ == "__main__":
    #print(len(sys.argv))
    conf_file = "./pro_conf.xml"
    data_out = ""
    if len(sys.argv) > 1:
        conf_file = sys.argv[1]
    if len(sys.argv) > 2:
        data_out = sys.argv[2]
    print(conf_file)
    print(data_out)
    start = time.time();
    pconf, err = pro_conf.parse_pro_conf(conf_file)
    if pconf == None:
        print("pro_conf parse_pro_conf failed.")
        sys.exit(-1)

    end = time.time();
    print ("parse_pro cost %f", end-start)
    # 替换数据输出目录
    if data_out != "":
        pconf.data_path = data_out

    global_change_files = []
    log_compare(pconf.xls_path,pconf.file_list,global_change_files,0,conf_file)
    add_log(pconf.xls_path,pconf.file_list,0,conf_file)

    for fen in pconf.file_list:
        #print("read_all_xls_data fconf:" + fen.target_name)
        xx = os.path.join(pconf.xls_path,fen.xls_file)
        if xx in global_change_files:
            print fen.xls_file
        else:
            continue
    
    print("pro_conf output ok.")