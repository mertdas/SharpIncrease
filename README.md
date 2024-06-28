# SharpIncrease

# Inflate

Adversaries may use binary padding to add junk data and change the on-disk representation of malware. This can be done without affecting the functionality or behavior of a binary, but can increase the size of the binary beyond what some security tools are capable of handling due to file size limitations.

Binary padding effectively changes the checksum of the file and can also be used to avoid hash-based blocklists and static anti-virus signatures.The padding used is commonly generated by a function to create junk data and then appended to the end or applied to sections of malware.Increasing the file size may decrease the effectiveness of certain tools and detection capabilities that are not designed or configured to scan large files. This may also reduce the likelihood of being collected for analysis. Public file scanning services, such as VirusTotal, limits the maximum size of an uploaded file to be analyzed


https://attack.mitre.org/techniques/T1027/001/


# SharpIncrease

SharpIncrease can bypass many security measures and can be used with various file extensions.

You can even increase the size of Windows Form Applications with null bytes.

The security products SharpIncrease has been tested against so far:

-E-Mail Security Products
-EDRs
-NextGenAVs
-AVs
-EPPs
![image](https://github.com/mertdas/SharpIncrease/assets/48562581/7e35fe25-7281-4423-9fdf-d2a0069865d0)

```

  ____  _                     ___
 / ___|| |__   __ _ _ __ _ __|_ _|_ __   ___ _ __ ___  __ _ ___  ___
 \___ \| '_ \ / _` | '__| '_ \| || '_ \ / __| '__/ _ \/ _` / __|/ _ \
  ___) | | | | (_| | |  | |_) | || | | | (__| | |  __/ (_| \__ \  __/
 |____/|_| |_|\__,_|_|  | .__/___|_| |_|\___|_|  \___|\__,_|___/\___|
                        |_|

            Mert Daş     @merterpreter


Usage: SharpIncrease.exe -D inputfile -S MB -O outputfile

```
![sharpincrease](https://user-images.githubusercontent.com/48562581/225166491-846654c6-c117-49d8-9c26-3dbb268af1e4.png)

## Proper USAGE:

SharpIncrease.exe -D yourmalmalware.exe -S 350 -O padded.exe
