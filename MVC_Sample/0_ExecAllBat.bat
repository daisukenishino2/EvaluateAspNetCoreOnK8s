echo | call 1_DeleteDir.bat
echo | call 1_DeleteFile.bat

@echo on
timeout 5

echo | call 3_Build_Business_netcore30.bat
echo | call 10_Build_WebAppCore_sample.bat

@echo on
timeout 5
