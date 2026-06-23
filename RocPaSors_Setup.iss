[Setup]
AppName=RocPaSors
AppVersion=1.0.0
AppPublisher=Corssexpy
AppPublisherURL=https://github.com/atilanaufal/RocPaSors
DefaultDirName={autopf}\RocPaSors
DefaultGroupName=RocPaSors
AllowNoIcons=yes
OutputDir=Installers
OutputBaseFilename=RocPaSors_Setup
Compression=lzma
SolidCompression=yes
PrivilegesRequiredOverridesAllowed=dialog
PrivilegesRequired=none
DisableDirPage=no
AllowRootDirectory=yes

[Files]
Source: "RocPaSors\publish\win-x64\*"; DestDir: "{app}"; Flags: recursesubdirs ignoreversion

[Icons]
Name: "{group}\RocPaSors"; Filename: "{app}\RocPaSors.exe"
Name: "{group}\Uninstall RocPaSors"; Filename: "{uninstallexe}"
Name: "{autodesktop}\RocPaSors"; Filename: "{app}\RocPaSors.exe"

[Run]
Filename: "{app}\RocPaSors.exe"; Description: "Launch RocPaSors"; Flags: nowait postinstall skipifsilent