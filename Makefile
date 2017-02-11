CS=csc /nologo
TARGET=DefectRand.exe

DefectRand.exe:
	$(CS) /out:DefectRand.exe /t:winexe main.cs AssemblyInfo.cs /win32icon:app.ico
