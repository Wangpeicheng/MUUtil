@echo off

@echo ���������
tool\\Python27\\python.exe tool\\data_output.py ./pro_conf.xml 0
if not %errorlevel% == 0 GOTO ERROR_OUT

@echo �ͻ��˱��
tool\\Python27\\python.exe tool\\data_output.py ./client_pro_conf.xml 1
if not %errorlevel% == 0 GOTO ERROR_OUT



Pause

:ERROR_OUT
Pause