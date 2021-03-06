#!/usr/bin/python
# -*- coding=utf-8 -*-

import xml.etree.ElementTree as etree

# 检查项
class CheckConf:
    def __init__(self):
        self.type = ""
        self.target = ""

# 单列配置
class ColumnConf:
    def __init__(self):
        # 列名
        self.column = ""
        # 输出名称
        self.name = ""
        # 输出类型
        self.type = ""
        # 
        self.is_key = False
        # >0, 数组长度
        self.count = 0
        # count对应的常量定义字符串
        self.count_const_value = ""
        # 检查项列表
        self.check_list = []
        # 文本替换功能串,格式(target表:原始列：目标列)
        #self.replace = ""
        # 关联枚举(该字段必须是number, 填表必须是desc, 自动替换)
        self.refer_enum = ""
            
# 文件配置
class FileConf:
    def __init__(self):
        # 目标名称
        self.target_name = "" 
        # xls
        self.xls_file = ""
        # xls sheet
        self.sheet_name = ""
        # 列项列表
        self.column_list = []

# 枚举项配置
class EnumFieldConf:
    def __init__(self):
        self.name = ""
        self.value = ""
        self.desc = ""

# 枚举配置
class EnumConf:
    def __init__(self):
        self.name = ""
        self.target_name = ""
        self.desc = ""
        self.field_list = []
        
    
# project 配置
class ProConf:
    def __init__(self):
        # xls目录
        self.xls_path = ""
        # 输出数据文件目录
        self.data_path = ""
        # 输出数据文件格式[txt/bin]
        self.data_type = ""
        # 输出生成代码路径
        self.code_path = ""
        # 输出生成代码格式[c++/c#/java]
        self.code_type = ""
        # 文件配置列表
        self.file_list = []
        # 枚举列表
        self.enum_file = ""
        self.enum_list = []
        # 数据开始行
        self.data_start_line = 3
        
# 解析
# return (conf_obj, err_str)
def parse_pro_conf(pfile):
    pconf = ProConf()
    try :
        xmldoc = etree.parse(pfile)
        root = xmldoc.getroot()
        pconf.xls_path = root.attrib["xls_path"]
        pconf.data_path = root.attrib["data_path"]
        pconf.data_type = root.attrib["data_type"]
        pconf.code_path = root.attrib["code_path"]
        pconf.code_type = root.attrib["code_type"]
        pconf.enum_file = root.attrib["enum_conf"]
        pconf.data_start_line = root.attrib["data_start_line"]
        for entry in root:
            fen = FileConf()
            fen.target_name = entry.attrib["target_name"]
            fen.xls_file = entry.attrib["xls_file"]
            fen.sheet_name = entry.attrib["sheet_name"]
            for column in entry:
                cc = ColumnConf()
                cc.column = column.attrib["column"]
                cc.name = column.attrib["name"]
                cc.type = column.attrib["type"]
                try:
                    key_str = column.attrib["key"]
                    if key_str == "True" or key_str == "true" or key_str == "1":
                        cc.is_key = True
                except:
                    pass
                try:
                    count_str = column.attrib["count"]
                    if count_str != "":
                        cc.count = int(count_str)
                except:
                    pass
                try:
                    count_const_value_str = column.attrib["count_const"]
                    if count_const_value_str != "":
                        cc.count_const_value = count_const_value_str
                except:
                    pass
                    
                try:
                    rep_str = column.attrib["refer_enum"]
                    if rep_str != "":
                        cc.refer_enum = rep_str
                except:
                    pass      
                
                for checkitem in column:
                    ci = CheckConf()
                    ci.type = checkitem.attrib["type"]
                    ci.target = checkitem.attrib["target"]
                    cc.check_list.append(ci)
                
                fen.column_list.append(cc)
            
            pconf.file_list.append(fen)
    except Exception as e:
        err_str = "project file:" + pfile + ",parse failed:" + str(e.args)
        return None, err_str

    if pconf.enum_file != "":
        ret, err_str = parse_enum_conf(pconf)
        if ret != True:
            return None, err_str

    return pconf, ""

# 加载解析enum配置文件
def parse_enum_conf(pconf):
    #pconf = ProConf()
    try :
        xmldoc = etree.parse(pconf.enum_file)
        root = xmldoc.getroot()
        for entry in root:
            econf = EnumConf()
            econf.name = entry.attrib["name"]
            econf.target_name = entry.attrib["target_name"]
            econf.desc = entry.attrib["desc"]
            for enum in entry:
                efiled = EnumFieldConf()
                efiled.name = enum.attrib["name"]
                efiled.value = enum.attrib["value"]
                efiled.desc = enum.attrib["desc"]
                econf.field_list.append(efiled)
            pconf.enum_list.append(econf)
    except Exception as e:
        err_str = "enum_file(%s) parse failed, %s." % (pconf.enum_file, e.args)
        return False, err_str

    return True, ""

if __name__ == "__main__":
    pconf, err = parse_pro_conf("./pro_conf.xml")  
    if pconf != None:
        print("Project Conf Parse Ok.")
        print("xls_path:" + pconf.xls_path)
        print("data_path:" + pconf.data_path)
    else:
        print("parse failed," + err)
