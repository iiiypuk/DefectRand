CS=csc /nologo
TARGET=DefectRand.exe

DefectRand.exe:
	$(CS) /out:DefectRand.exe main.cs AssemblyInfo.cs /win32icon:app.ico
