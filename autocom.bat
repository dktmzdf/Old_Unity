
@echo off
if not exist C:\Users\KICT-06\Desktop\Unity\%1\%2 goto:EXIT
@echo on
git add .
cd ..
cd %1
git add *.sin
cd %2
rm -rf bin
rm -rf obj
git add .
git commit -m "%2"
git push
cd ..
cd ..
:EXIT


