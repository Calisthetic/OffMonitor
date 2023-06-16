# Useful programms repo

## List

- MonitorOff
- ScreenByClick

## Dev

### How to build

```bash
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true
```

Official command

```bash
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained false
```
