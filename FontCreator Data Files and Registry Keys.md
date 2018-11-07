# FontCreator Data Files and Registry Keys
This document represents the data files and registry keys in FontCreator.

## Notes
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
* Versions prior 7.0 includes a built-in PostScript name list designed for Adobe fonts. The glyph **xi** assigns a codepoint of U+0000.

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

### Install
* **InstallFontsInFontsFolder** – This corresponds to the **Install the font in Windows Fonts folder** option in the Font Installation Wizard. Default is on. When used with Windows Vista and above, you must have administrator privileges to install the font in Windows Fonts folder.

### Interface Settings
* **GlyphCaptionType** – Used with Caption radio buttons in the Overview tab. (Available in the Options window)
* **KerningFolderExport** – Directory for exporting the legacy kerning tables.
* **KerningFolderImport** – Directory for importing the legacy kerning tables.
* **OpenDialogInitialDir** – Directory used in Open dialog.
* **OpenDialogInitialDirAutoKerning** – Directory used in AutoKern Open dialog.
* **OpenDialogInitialDirImportImage** – Directory used in Import Image Open dialog.
* **OpenDialogInitialDirNamingField** – Directory used in Edit Naming Field Open dialog.
* **OpenDialogInitialDirTransform** – Directory used in Glyph Transformer Open dialog.
* **OverviewSampleFont** – Used with **Font overview: Font used by samples** option in the Overview tab. Default is Arial. If empty, all glyphs are displayed using MS Sans Serif with all glyphs shifted to other position. (Available in the Options window)
* **OverviewShowCaption** – Used with **Font overview: Show caption** option in the Overview tab. Default is on. (Available in the Options window)
* **OverviewSingleHeight** – Used with **Font overview: Glyph height** option in the Overview tab. Default is 48. (Available in the Options window)
* **OverviewSingleWidth** – Used with **Font overview: Glyph width** option in the Overview tab. Default is 70. (Available in the Options window)
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** option in the Overview tab. (Available in the Options window)
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** option in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** option in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUseColor** – Used with **Font overview: Use type color in glyph caption** option in the Font tab. If enabled, glyph captions are shown in different colors. If disabled, glyph captions are shown in black. (Available in the Options window)
* **SampleFileName** – Used with **Samples Toolbar: Filename** option in the Sample tab. Default is blank. (Available in the Options window)
* **SampleSingleHeight** – Used with **Samples Toolbar: Glyph height** option in the Sample tab. Default is 55. (Available in the Options window)
* **SampleSingleWidth** – Used with **Samples Toolbar: Glyph width** option in the Sample tab. Default is 62. (Available in the Options window)

### Kerning (Versions 5.0 through 6.5)
* **AutoKerningAllowForPositiveKerningValues** – This corresponds to the **Additional Options: Allow for positive kerning values** option in the AutoKern window.
* **AutoKerningImportFilename** – This corresponds to the disabled text box with the filename string.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** option in the AutoKern window.
* **AutoKerningReplaceKerning** – This corresponds to the **Additional Options: Replace existing kerning when** dropdown box in the AutoKern window.
* **AutoKerningReplacePercentage** – This corresponds to the **Additional Options: Replace existing kerning when** slider in the AutoKern window.
* **AutoKerningWhiteSpace** – This corresponds to the **Additional Options: White space between characters** option in the AutoKern window.
* **KerningColorGridLines** – Select the color used for the Grid Lines.
* **KerningColorLeft** – Select the color used for the left glyph. Default is dark blue.
* **KerningColorRight** – Select the color used for the right glyph.
* **KerningShowBearingLines** – Display bearing lines in Kerning window.
* **KerningShowGridLines** – Display grid lines in Kerning window.

### Last Time
* **File_#** – Include last time used fonts whereas # is a number. When **OnStartupOpenFonts** is enabled, no fonts are opened if this file is deleted.

### Metrics
* **AutoMetricsExcludeEmptyGlyphs** – This corresponds to the **Additional Options: Exclude empty glyphs (recommended)** option in the AutoMetrics window.
* **AutoMetricsFixedAW** – This corresponds to the **Fixed: Change Advance Width** spinner in the AutoMetrics window.
* **AutoMetricsFixedChangeAW** – This corresponds to the **Fixed: Change Advance Width** option in the AutoMetrics window.
* **AutoMetricsFixedChangeLSB** – This corresponds to the **Fixed: Change Left Side Bearing** option in the AutoMetrics window.
* **AutoMetricsFixedLSB** – This corresponds to the **Fixed: Change Left Side Bearing** spinner in the AutoMetrics window.
* **AutoMetricsOptionIndex** – This corresponds to the radio buttons in the AutoMetrics window.
* **AutoMetricsWhiteSpaceAfter** – This corresponds to the **Calculated: White space after characters** option in the AutoMetrics window.
* **AutoMetricsWhiteSpaceBefore** – This corresponds to the **Calculated: White space before characters** option in the AutoMetrics window.

### MetricsAndKerning
* **MetricsAndKerningKerningEnabled** – This corresponds to **Kerning** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextEnabled** – This corresponds to **Show text before and after glyph** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextLeft** – This corresponds to **Before** text box in the Comparison toolbar. Default is empty.
* **MetricsAndKerningTextRight** – This corresponds to **After** text box in the Comparison toolbar. Default is empty.

### Most Recently Used Files
* **File_#** – Lists the font file names in the **File: Reopen** menu (# is a number). The menu will appear dimmed if deleted.

### Options
* **AlwaysCreateBackupCopy** – This corresponds to the **When Saving Font Files: Always create backup copy (bak)** option in the Font tab. If disabled, no backup copy is created on saving. (Available in the Options window)
* **AutoFitGlyphInWindow** – This corresponds to the **Zoom Simple Glyph Edit Window: Auto Fit Glyph in Window** option in Options: Glyph. Default is on.
* **AutoNamingUseFontRevision** – This corresponds to the **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** option in Options: Naming. Default is on.
* **CompressHmtxTable** – This corresponds to the **When Saving Font Files: Compress hmtx table** option in the Font tab. (Available in the Options window)
* **CompressNameTable** – This corresponds to the **When Saving Font Files: Optimize name table** option in the Font tab. (Available in the Options window)
* **DefaultNamingCopyrightIncluded** – This corresponds to the **Default Naming for New Fonts: Copyright** checkbox in Options: Naming. Default is on.
* **DefaultNamingCopyrightText** – This corresponds to the **Default Naming for New Fonts: Copyright** option in Options: Naming. Default is **Typeface © (your company). &lt;year&gt;. All Rights Reserved.**
* **DefaultNamingFontDesignerIncluded** – This corresponds to the **Default Naming for New Fonts: Font Designer** checkbox in Options: Naming.
* **DefaultNamingFontDesignerLinkText** – This corresponds to the **Default Naming for New Fonts: Font Designer Link** option in Options: Naming.
* **DefaultNamingFontDesignerText** – This corresponds to the **Default Naming for New Fonts: Font Designer** option in Options: Naming. Default is empty.
* **DefaultNamingLicenseAgreementIncluded** – This corresponds to the **Default Naming for New Fonts: License Agreement** checkbox in Options: Naming.
* **DefaultNamingLicenseAgreementLinkIncluded** – This corresponds to the **Default Naming for New Fonts: License Agr. Link** checkbox in Options: Naming.
* **DefaultNamingLicenseAgreementLinkText** – This corresponds to the **Default Naming for New Fonts: License Agr. Link** option in Options: Naming.
* **DefaultNamingLicenseAgreementText** – This corresponds to the **Default Naming for New Fonts: License Agreement** option in Options: Naming. Default is empty.
* **DefaultNamingTrademarkIncluded** – This corresponds to the **Default Naming for New Fonts: Trademark** checkbox in Options: Naming.
* **DefaultNamingTrademarkText** – This corresponds to the **Default Naming for New Fonts: Trademark** option in Options: Naming. Default is &lt;font family&gt;® Trademark of (your company).
* **DefaultZoomFactor** – This corresponds to the **Zoom Simple Glyph Edit Window: Open with Default Zoom Factor** option in Options: Glyph.
* **ExcludeMonospacedFonts** – This corresponds to the **When Saving Font Files: Exclude monospaced fonts** option in the Font tab. If enabled, it will omit all monospace fonts on saving. If disabled, no monospace fonts are omitted during saving. (Available in the Options window)
* **IgnoreHintingData** – This corresponds to the **When Opening Font Files: Remove hinting data** option in the Font tab. If enabled, hinting data is removed. If disabled, hinting data is kept. (Available in the Options window)
* **IgnoreUnsupportedTables** – This corresponds to the **When Opening Font Files: Remove unsupported tables** option in the Font tab. If enabled, unsupported tables are removed. If disabled, unsupported tables are kept. (Available in the Options window)
* **LastUpdateReminderDate** – Used when **OnStartupShowUpdateReminder** is enabled.
* **LeftSideBearingExcludeLargeFonts** – This corresponds to the **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** option in the Font tab. If enabled, it will omit all fonts with a large number of glyphs on saving. (Available in the Options window)
* **LongAlignedLocalOffsets** – This corresponds to the **When Saving Font Files: Long-aligned local offsets** option in the Font tab. (Available in the Options window)
* **OnStartupOpenFonts** – This corresponds to the **Startup: On start open fonts from last time** option in the General tab. Default is on. (Available in the Options window)
* **OnStartupShowUpdateReminder** – This corresponds to the **Startup: Show update reminder** option in the General tab. Default is Once a year. (Available in the Options window)
* **OnStartupShowWelcome** – This corresponds to the **Startup: On start show Welcome dialog** option in the General tab. Default is on. (Available in the Options window)
* **PanoseValueHexadecimal** – This corresponds to the **PANOSE: HEX** option in the Classification tab. If enabled, the PANOSE value is displayed in hexadecimal. If disabled, the PANOSE value is displayed in decimal. (Available in the Font Settings window)
* **RecalcAverageCharWidth** – This corresponds to the **When Saving Font Files: Recalc average char width** option in the Font tab. (Available in the Options window)
* **RecalcGlyphBoundingBoxes** – This corresponds to the **When Saving Font Files: Recalc glyph bounding boxes** option in the Font tab. (Available in the Options window)
* **RemoveDSIGTable** – This corresponds to the **When Opening Font Files: Remove DSIG table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.2 only)
* **RemoveHdmxTable** – This corresponds to the **When Opening Font Files: Remove hdmx table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.2 only)
* **RemoveLTSHTable** – This corresponds to the **When Opening Font Files: Remove LTSH table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.2 only)
* **RemoveVDMXTable** – This corresponds to the **When Opening Font Files: Remove VDMX table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.2 only)
* **SetLeftSideBearingPointAtX0** – This corresponds to the **When Saving Font Files: Set left side bearing point at x=0** option in the Font tab. (Available in the Options window)
* **UnicodeEnabledGUI** – In version 5.5 through 6.5 only. This corresponds to the **Unicode Support: Enable Unicode support for text display and user input** option in the General tab. Default is on. If disabled, it will use the current codepage according to the Language For Non-Unicode Programs variable. If you run it on Windows 9x/ME or compatibility mode, this option will appear dimmed.
* **UpdateModifiedDateTimeField** – This corresponds to the **When Saving Font Files: Update Modified DateTime field** option in the Font tab. Default is on. (Available in the Options window)
* **ValueHexadecimal** – This corresponds to the **Values: Hexadecimal** option in the General tab. Default is on. Hexadecimal values in Delphi are usually given with a dollar sign ($). (Available in the Options window)

### Preview
* **PreviewFontSize** – This corresponds to the size in the Test Font window.
* **PreviewSampleFontSize** – This corresponds to the size in the Preview window.
* **PreviewSampleText** – Used with the dropdown box in the Preview window. Default is **High-Logic ©**.
* **PreviewSampleUseKerning** – Used for **Kerning** in the Preview window.
* **ShowToolbarWindowPreview** – Default is on.
* **StrikeThrough** – Used for **Strikeout** in the Test Font window.
* **Underline** – Used for **Underline** in the Test Font window.

### Reg
The license is deactivated and program is started in unregistered mode if this key is removed.
* **V5D#** – Created when registering the program whereas # is a numerical string. It displays a message and removes the **Register** item on the Help menu and button in **TTIPOFTHEDAYFORM**. Version 6.0 and newer places your name on the title bar.

### Themes
* **ActiveTheme** – No meaning

### Tip of the Day
* **CurrentTip** – Current line number in FontCreator.tip, used when opening the **Tip of the Day** window.
* **ShowTipOnStartup** – In old versions only; used when selecting **Show this screen next time when you start the Font Creator Program** in the **Tip of the Day** window.

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – This corresponds to the **Diagonal redundant points detection: Max. off-curve dist.** option in the Validation tab. (Available in the Settings window)
* **DiagonalRedundantOnCurvePointsDetection** – This corresponds to the **Diagonal redundant points detection: Max. on-curve dist.** option in the Validation tab. (Available in the Settings window)
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar.
* **LocalExtremeCoordinatesDetection** – This corresponds to the **Off-curve extreme coordinates: Local detection** option in the Validation tab. (Available in the Settings window)
* **MaximumRedundantOffCurvePointsDistance** – This corresponds to the **Diagonal redundant points detection: Max. off-curve dist.** spinner in the Validation tab. (Available in the Settings window)
* **MaximumRedundantOnCurvePointsDistance** – This corresponds to the **Diagonal redundant points detection: Max. on-curve dist.** spinner in the Validation tab. (Available in the Settings window)
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. If enabled, intersecting contours are shown for each glyph. If disabled, no intersecting contours are shown for each glyph. If too complex, the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. If enabled, warning points are shown for each glyph. If disabled, no warning points are shown for each glyph. If too complex, the button will appear dimmed.
* **TestContoursWithIncorrectDirection** – Used with **Validation Tests: Contours with incorrect direction** in the Font Validation Wizard and **Correct Contour Directions** in the Validation toolbar.
* **TestContoursWithOneOrTwoPoints** – Used with **Validation Tests: Contours with one or two points** in the Font Validation Wizard and **Remove Components** in the Validation toolbar.
* **TestDuplicateComponents** – Used with **Validation Tests: Duplicate components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar.
* **TestDuplicateContours** – Used with **Validation Tests: Duplicate contours** in the Font Validation Wizard and **Remove Duplicate Contours** in the Validation toolbar.
* **TestDuplicateKnots** – Used with **Validation Tests: Duplicate knots** in the Font Validation Wizard and **Remove Duplicate Knots** in the Validation toolbar.
* **TestEmptyComponents** – Used with **Validation Tests: Empty components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar.
* **TestFixDetectedProblems** – Used with **Fix detected problems** in the Font Validation Wizard.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in the Font Validation Wizard.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in the Font Validation Wizard and **Add Off-Curve Extremes** in the Validation toolbar.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in the Font Validation Wizard and **Remove Redundant Points** in the Validation toolbar.
* **ValidationMaxNumberOfCompositeGlyphMembers** – This corresponds to the **Real-time glyph validation: Disable when number of members exceeds** option in the Validation tab. (Available in the Settings window)
* **ValidationMaxNumberOfContours** – This corresponds to the **Real-time glyph validation: Disable when number of contours exceeds** option in the Validation tab. (Available in the Settings window)
* **ValidationMaxNumberOfPoints** – This corresponds to the **Real-time glyph validation: Disable when number of points exceeds** option in the Validation tab. (Available in the Settings window)

### Warn – Default is on for all options
* **WarnBeforeActivatingFixFeature** – Used with **Warn before activating the fix feature in the Font Validation Wizard** setting in the Advanced tab.
* **WarnBeforeActivatingRemoveFeature** – Used with **Warn before activating a remove feature from the Options → Font page** setting in the Advanced tab.
* **WarnBeforeAddCharacters** – Used with **Warn before adding characters** setting in the Advanced tab.
* **WarnBeforeExecutingGlyphTransformProgram** – Used with **Warn before executing Glyph Transformer script** setting in the Advanced tab.
* **WarnBeforeSortingGlyphs** – Used with **Warn before sorting glyphs** setting in the Advanced tab.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts** setting in the Advanced tab.
