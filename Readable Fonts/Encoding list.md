The readable font family is based on the works of System VIO fonts from IBM OS/2.

### Encodings with a set numerical value
| File Name | Description     |
|-----------|-----------------|
| FILE      | File            |

### Transcription/Transliteration Font Encodings
| File Name | Description                                 |
|-----------|---------------------------------------------|
| ALALCT1   | ALA-LC Transliteration 1                    |
| ALALCT2   | ALA-LC Transliteration 2                    |
| AVESCZEC  | Avestan + Czech letters on cp852 codepoints |
| AVESTRAN  | Avestan                                     |
| IRTRARHE  | Iranian – Arabic & Hebrew                   |
| ISOCYTRA  | ISO 9 (Cyrillic) – Slavic languages         |
| KASHMIRI  | Kashmiri                                    |
| SEMTRAN1  | Semitic – Arabic                            |
| SEMTRAN2  | Semitic – Hebrew, Meroitic, Ugaritic        |
| SEMTRAN3  | Semitic – Akkadic, Egyptian, Sumerian       |
| TITUSHS   | TITUS Hebrew & Semitic                      |
| TITUSOC   | TITUS Oriental Christian                    |

### Notice when loading fonts through LOADFONT
LOADFONT (1993) from FNTCOL version 1.6 cannot handle long filenames or directory names.  If you want to pass these to LOADFONT you will have to rename or abbreviate them to their 8.3 character DOS filenames from the tables at the beginning.  EG: **Atari ST Encoding.f16** is **ATARIS~1.F16** and that is what you would have to pass to LOADFONT.
