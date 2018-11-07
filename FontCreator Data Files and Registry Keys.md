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

## Registry Keys

### AddCharacters
* **SelectedCharacter** – Character used in the **Insert Characters** dialog. Default is beginning of Basic Latin Unicode block.
* **SelectedFont** – Font used in the **Insert Characters** dialog. Default is **Arial Unicode MS** if you have the Microsoft Office suite installed.

### Columns
* **Open Installed Fonts** – This is a binary value.

### Find
* **FindLanguageID** – This corresponds to any language.
* **PlatformID** – See **Platform** in the Find dialog's Mapping tab.
* **PlatformSpecificEncodingID** – See **Platform** in the Find dialog's Mapping tab.
* **TabIndex** – This corresponds to any tab in the Find dialog.

### Glyph Edit Window
* **FilledOutline** – Used with **Fill Outline** in the Grid toolbar.
* **ShowConnectionBetweenPoints** – Used with **Show Connection** in the Grid toolbar. Default is on.
* **ShowFirstAndLastPointIndicators** – Used with **Show First and Last** in the Grid toolbar. Default is on.
* **ShowToolbarWindowBackground** – Enables or disables the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Enables or disables the kerning window. Default is off.
* **ShowToolbarWindowTransformation** – Used with **Transformation** in the toolbar right click context menu.
* **ShowToolbarWindowValidation** – Used with **Show Report** in the Glyph toolbar. Default is off.

### Grid
* **FixedGridColor** – This corresponds to the **Color** option in Grid Options. Default is pink.
* **FixedGridLineStyle** – This corresponds to the **Line style** option in Grid Options. Default is solid.
* **GridColor** – This corresponds to the **Color** option in Grid Options. Default is pink.
* **GridDistance** – This corresponds to the **Mininum distance between grid points in units** option in Grid Options.
* **GridDistancePixels** – This corresponds to the **Mininum distance between grid points in pixels** option in Grid Options.
* **GridLineStyle** – This corresponds to the **Line style** option in Grid Options. Default is solid.
* **IncludeBaseline** – This corresponds to the **Baseline** option in the Metrics Options window.
* **IncludeLeftSideBearing** – This corresponds to the **Left side bearing** option in the Metrics Options window.
* **IncludeRightSideBearing** – This corresponds to the **Right side bearing** option in the Metrics Options window.
* **IncludeTypoAscender** – This corresponds to the **TypoAscender** option in the Metrics Options window.
* **IncludeTypoDescender** – This corresponds to the **TypoDescender** option in the Metrics Options window.
* **IncludeWinAscent** – This corresponds to the **Win Ascent** option in the Metrics Options window.
* **IncludeWinDescent** – This corresponds to the **Win Descent** option in the Metrics Options window.
* **IncludexHeight** – This corresponds to the **x-Height** option in the Metrics Options window.
* **IncludeYAxis** – This corresponds to the **Y-Axis** option in the Metrics Options window.
* **LockUserDefinedGuidelines** – Used when pressing **Lock Guidelines** in the Grid toolbar.
* **ShowBearings** – Used when pressing **Show Metrics** in the Grid toolbar.
* **ShowFixedGridLines** – This corresponds to the **Show reference lines at x = 0, y = 0** option in Grid Options.
* **ShowGrid** – Used when pressing **Show Grid** in Grid Options or in the Grid toolbar.
* **ShowUserDefinedGuidelines** – Used when pressing **Show Guidelines** in Guidelines Options or in the Grid toolbar. If Microsoft Narrator is active, the checkbox in the Guidelines Options window will read the ampersand.
* **SnapToGrid** – Used when pressing **Snap to Grid** in the Grid toolbar.
* **SnapToUserDefinedGuidelines** – Used when pressing **Snap to Guidelines** in the Grid toolbar.

### GuideLines
* **Color** – This corresponds to the **Color** option in Guideline Options. Default is black.
* **LineStyle** – This corresponds to the **Line style** options in Guideline Options. Default is solid.

### ImportImage
* **BitmapPositionOrigin** – This corresponds to the radio buttons in the Glyph: Position option. (Available in Import Image)
* **BitmapPositionType** – Set the Bitmap Position Type.
* **Erode** – This corresponds to the **Erode – Dilate** option in the Image tab. Default is No filter. (Available in Import Image)
* **GlyphPositionX** – This corresponds to the **Position: X position** option in the Glyph tab. (Available in Import Image)
* **GlyphPositionY** – This corresponds to the **Position: Y position** option in the Glyph tab. (Available in Import Image)
* **ImportMode** – This corresponds to the **Import Mode** option in the Glyph tab. Default is Trace. (Available in Import Image)
* **InvertBitmap** – This corresponds to the **Negative** option in the Image tab. Default is off. (Available in Import Image)
* **MinimumPointsInCountour** – Set the number of Minimum Points in the contour.
* **Multiplier** – This corresponds to the **Size: Multiplier** option in the Image tab. (Available in Import Image)
* **SmoothFilter** – This corresponds to the **Smooth Filter** option in the Image tab. Default is Smooth. (Available in Import Image)
* **Threshold** – This corresponds to the **Threshold** option in the Image tab. Default is 150. (Available in Import Image)
