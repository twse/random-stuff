# FontCreator Data Files and Registry Keys
This document represents the data files and registry keys in FontCreator.

* Complete Composites slows down the first time using in simple and composite glyphs.
* Glyphs and glyph outlines stored in the clipboard will have either the text "Glyph Contours" or "Glyph Data".
* If you exit the program, it may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* If you want to change resources in non-standard resource layout versions, you would have to use Resource Tuner ($) (tested with latest version) or UPX (tested with the version distributed with FreeDOS from late 2006) to unpack the executable file which isn't possible as UPX halts with "not packed by UPX".
* In new fonts, the Euro (€) doesn't have a Macintosh Roman mapping but the international currency sign (¤) does have it.
* The cursor will remain "Busy" when saving fonts while you do other stuff in the background.
* The euro (€) and international currency sign (¤) use the same mapping in the Macintosh Roman glyph mapping list.
* The menu item **Edit: Delete** is not dimmed on startup or when closing other dialogs.
* The postscript name generation and additions to preview toolbar in versions 5.0 through 6.5 only supports glyphs with a Windows Unicode BMP mapping.
* The program displays a critical error if you use Complete Composites in some glyphs in the Private Use Area. After that, these glyphs cannot be recovered. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html) has assigned code points in the Private Use Area for different glyphs in his fonts, notably low profile diacritics and small capitals.
* The program displays the "Access violation" when closing after doing some operations – the font(s) may be invalid.
* Versions from 1.0 through 6.5 only has one icon for the executable file.
* Versions from 1.0 through 6.5 use Latin-1 as the output encoding. Korean users will appreciate in previewtext.dat substitutes accented letters by ASCII counterparts, e.g. é by e and if kerning pairs are exported, instead of having &lt;&lt; for « you have to use \\00AB as escape code.
* Versions from 1.0 through 7.0 does not support unmapped glyph(s) or glyph(s) with Unicode SMP mapping(s) in the preview toolbar.
* Versions from 5.0 through 6.0 makes **Complete Composites** dimmed in empty glyph(s).
* Versions from 5.0 through 7.0 allows you to save all unaltered opened fonts from the menu (**File: Save All**) but not in the Standard toolbar. In double-byte versions of Windows, the system may display a critical error saying "List index out of bounds (0)". Single-byte versions of Windows does nothing.
* Versions prior 7.0 includes a built-in PostScript name list designed for Adobe fonts. The glyph *xi** assigns a codepoint of U+0000.

### User Data (Glyph Transformer scripts and Unicode data files omitted)
* **bookmarks.txt** – Created automatically after exit. Includes bookmarks used in the glyph overview window for each Unicode codepoint.
* **CompositeData.xml** – Located in the Composite folder as used by **Complete Composites**. If you get any errors, edit the file and restart the program.
* **CurrentTransformProgram.xml** – Created when opening a Transform Program in the Glyph Transformer. If removed, this window appears blank.
* **FC#####.ttf** – Located in temporary folder when opening the Test Font Window (##### is a string of five numbers). The font name is FC Test Font ###### (###### is a string of six numbers).
* **fcppreview.txt** – For old versions of FontCreator, includes the text used in the Test Font Window. Text in TFONTTESTFORM is restored to factory defaults if removed. (See previewtext.dat in recent versions)
* **fntXX.tmp** – Used when saving fonts (XX is a letter and number combo).
* **FontCreatorSetup.exe** – Used to reinstall the program.
* **FontCreator.tip** – Located in the program folder to store tips in the Tip of the Day Window. If removed, this window appears blank.
* **guidelines.dat** – Created automatically after exit. Includes guidelines used in Glyph Edit window and Guideline Options.
* **kern_filename.txt** – For old versions of FontCreator, stores the legacy kerning pair data for each font whereas filename is the name of each font.
* **previewtext.dat** – Includes text used in Test Font Window. Text in TFONTTESTFORM is restored to factory defaults if removed.
* **SubFamily.dat** – Located in the program folder to store naming fields for different languages.
* **TableOffsetOrder.dat** – Located in the program folder as used by Font Tables: Supported. All tables are moved to Unsupported if removed.
