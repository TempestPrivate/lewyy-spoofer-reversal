@echo off
title Registry Cleaner 
color 3
echo. 
echo.
echo.
echo Cleaning Registry Keys...
echo.
echo =================================================================================


reg delete "HKEY_CURRENT_USER\Software\Blizzard Entertainment\Battle.net\Identity" /f
reg delete "HKEY_CURRENT_USER\SOFTWARE\Blizzard Entertainment" /f
reg delete "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Blizzard Entertainment" /f
reg delete "HKEY_CURRENT_USER\SOFTWARE\Activision\Call of Duty Black Ops Cold War" /f
reg delete "HKEY_CURRENT_USER\SOFTWARE\Activision" /f

echo =================================================================================
echo.
echo Deleted trace files... 
echo If the registry keys were not found, then there are no traces...
echo.
echo.
echo.

PAUSE