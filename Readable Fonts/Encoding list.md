## Information
The readable font family is based on the System VIO font from IBM OS/2. It originally created as non-resident fonts.

### Encodings
| File Name | Description       |
|-----------|-------------------|
| CP30034   | Cherokee          |
| MININD    | Minion Indologist |

### Note when loading fonts through LOADFONT (FNTCOL version 1.6)
LOADFONT cannot handle long filenames or directory names. If you want to pass these to LOADFONT you will have to rename or abbreviate them to their 8.3 character DOS filenames from the tables above. EG: **Minion Indologist.f16** is **MINION~1.F16** and that is what you would have to pass to LOADFONT.
