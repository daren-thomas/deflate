# deflate

This project provides two simple programs:

- `deflate.exe`
- `inflate.exe`

They are implented using the `System.IO.Compression.DeflateStream` provided in .NET.

Usage:

```cmd
C:\> type MYFILE | deflate.exe > MYFILE.deflated
C:\> type MYFILE.deflated | inflate.exe > MYFILE
```
