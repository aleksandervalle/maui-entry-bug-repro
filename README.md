# Entry bug in .NET MAUI (.NET 8 RC2)

## Description

The bug seems to be present if `Entry` is used alongside `RoundRectangle` (possibly others?) inside a `Grid` (possible other containers?):

```
<Grid>
    <RoundRectangle Fill="Red" />
    <Entry x:Name="MyEntry" Text="{Binding MyText}" />
</Grid>
```

If I remove the `RoundRectangle`, the bug is not present.

## Demo
![Demo of entry bug](https://github.com/aleksandervalle/maui-entry-bug-repro/raw/main/entry-bug-demo.gif "Demo of entry bug")