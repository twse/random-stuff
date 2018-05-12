The readable font family is based on the works of System VIO fonts from IBM OS/2.

### Encodings with a set numerical string
| File Name | Description                                |
|-----------|--------------------------------------------|
| CP668     | Polish letters on cp852 codepoints         |
| CP899     | Armenian                                   |
| CP952     | Yugoslavian letters on cp852 codepoints    |
| CP1285    | Apple Romanian                             |
| CP3012    | Cyrillic Russian and Latvian ("RusLat")    |
| CP3845    | Hungarian                                  |
| CP30001   | Celtic                                     |
| CP30002   | Cyrillic Tajik                             |
| CP30007   | Latin                                      |
| CP30013   | Cyrillic Volga District - Turkic languages |
| CP30018   | Cyrillic Russian and Latin Tatar           |
| CP30019   | Cyrillic Russian and Latin Chechen         |
| CP30022   | Canadian First Nations                     |
| CP30033   | Crimean Tatar with Hryvnia                 |
| CP30034   | Cherokee                                   |
| CP30040   | Cyrillic Russian with Hryvnia              |
| CP59234   | Cyrillic Tatar                             |
| CP59829   | Georgian                                   |
| CP60258   | Cyrillic Russian and Latin Azeri           |
| CP60853   | Georgian with capital letters              |
| CP62306   | Cyrillic Uzbek                             |

### Encodings without a set numerical value
| File Name | Description                                    |
|-----------|------------------------------------------------|
| BASQUE    | Basque                                         |
| CZECH     | Czech letters on cp852 codepoints              |
| CZECHLF   | LinguaFont Czech                               |
| GUARANI   | Guarani letters on cp30023 codepoints          |
| HAUSA     | Hausa letters on African codepoints            |
| IBERIAN   | Iberian letters on cp850 codepoints            |
| ILPROM    | ILPRumanianB100                                |
| KURCYR    | Cyrillic Kurdish Kurmanjî                      |
| KURLAT    | Latin Kurdish Yekgirtú & Kurmanjî              |
| LAT8EXT   | Extended Latin-8                               |
| LT_UNIX   | Accented Lithuanian (Unix)                     |
| MACPOL    | Polish letters on Apple CE codepoints          |
| MALTESE   | Maltese letters on CP853 codepoints            |
| PALM      | Palm OS Latin-1                                |
| POLISHLF  | LinguaFont Polish                              |
| ROMANIAN  | Romanian letters on cp852 codepoints           |
| TAMAZIGH  | Tamazight/Berber letters on cp30028 codepoints |
| TMSEUS    | Times New Roman Basque                         |
| TNR_CYM   | Pryd Euro-Cymraeg                              |
| TNR_MGR   | Times New Roman Hungarian                      |
| TURKLAT   | Turkic Latin                                   |
| TURKMEN   | Turkmen letters on cp852 codepoints            |
| VGAF_HY   | VGAFONT Armenian                               |
| VIETBOX   | Vietnamese (lowercase tones and box drawing)   |

### Transcription/Transliteration Font Encodings
| File Name | Description                                      |
|-----------|--------------------------------------------------|
| ALALCT1   | ALA-LC Transliteration 1                         |
| ALALCT2   | ALA-LC Transliteration 2                         |
| APPEAL    | Appeal                                           |
| ARMGEOR   | Armenian/Georgian                                |
| AVESCZEC  | Avestan + Czech letters on cp852 codepoints      |
| AVESTRAN  | Avestan                                          |
| BHTITIME  | BharatiTimes                                     |
| BPSTRAN   | Buddhist Publication Society                     |
| CS        | Classical Sanskrit                               |
| CSX       | Classical Sanskrit Extended                      |
| CSXALT    | Classical Sanskrit Extended – Alternate encoding |
| DV1Y      | DV1-TTYogesh                                     |
| GANDHARI  | Times Gandhari                                   |
| GGM       | Gaudiya Grantha Mandira                          |
| GGM_DOS   | Gaudiya Grantha Mandira (DOS)                    |
| HOBOGIR   | Hobogirin                                        |
| INDOSKR   | IndoSkript                                       |
| IRTRARHE  | Iranian – Arabic & Hebrew                        |
| ISOCYTRA  | ISO 9 (Cyrillic) – Slavic languages              |
| IT98      | Itranslator 98                                   |
| ITIMESSK  | ITimesSkRom                                      |
| ITRANSL   | Itranslator                                      |
| KANNTRAN  | Kannada with ISO 15919 diacritics                |
| KASHMIRI  | Kashmiri                                         |
| KULMIX    | Catholic University Lublin Mixed Font            |
| KULTRAN   | Catholic University Lublin Transliteration       |
| MALATRAN  | Malayalam with ISO 15919 diacritics              |
| MININD    | Minion Indologist                                |
| MONGTRAN  | Mongolian                                        |
| NINATRAN  | Nina/Original Garamond: IJTS Transliteration     |
| NORMYN    | Kenneth Roy Norman                               |
| OTTOMAN   | Ottoman Turkish (ALA-LC)                         |
| PASKT     | URW Palladio SKT                                 |
| PINYIN    | Chinese (Pinyin)                                 |
| PKTC      | PKTC                                             |
| SANSKRT   | Sanskrit                                         |
| SEMTRAN1  | Semitic – Arabic                                 |
| SEMTRAN2  | Semitic – Hebrew, Meroitic, Ugaritic             |
| SEMTRAN3  | Semitic – Akkadic, Egyptian, Sumerian            |
| SINHTRAN  | Sinhala with ISO 15919 diacritics                |
| SKTRAN    | Searchable Sanskrit                              |
| SKTRANDE  | Searchable Sanskrit for German people            |
| TAMILTRN  | Tamil with ISO 15919 diacritics                  |
| TELUGTRN  | Telugu with ISO 15919 diacritics                 |
| TITUSEO   | TITUS Eastern Oriental                           |
| TITUSHS   | TITUS Hebrew & Semitic                           |
| TITUSII   | TITUS Indo-Iranian                               |
| TITUSOC   | TITUS Oriental Christian                         |
| WNRI      | Washington Romanized Indic                       |

### Extras
| File Name | Description     |
|-----------|-----------------|
| BACKWARD  | Horizontal Flip |
| INVERTED  | Vertical Flip   |
| MIXCASE   | MiXeD CaSe      |
| REVERSE   | Inverted Screen |

### Notice when loading fonts through LOADFONT
LOADFONT (1993) from FNTCOL version 1.6 cannot handle long filenames or directory names.  If you want to pass these to LOADFONT you will have to rename or abbreviate them to their 8.3 character DOS filenames from the tables at the beginning.  EG: **Atari ST Encoding.f16** is **ATARIS~1.F16** and that is what you would have to pass to LOADFONT.
