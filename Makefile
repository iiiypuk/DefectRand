CS=csc /nologo
TARGET=DefectRand.exe

CS2=C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc /nologo
TARGET2=DefectRand_net2.0.exe

all: DefectRand.exe

DefectRand.exe:
	$(CS) /out:$(TARGET) /t:winexe main.cs AssemblyInfo.cs /win32icon:app.ico

NET2:
	$(CS2) /out:$(TARGET2) /t:winexe main.cs AssemblyInfo.cs /win32icon:app.ico

clean:
	del DefectRand.exe DefectRand_net2.0.exe
