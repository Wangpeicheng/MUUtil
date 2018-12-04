@echo 客户端表格
tool\\Python27\\python.exe tool\\lua_output.py ./client_pro_conf.xml 1
if not %errorlevel% == 0 GOTO ERROR_OUT
Pause

:ERROR_OUT
Pause