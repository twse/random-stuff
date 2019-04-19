## Notes
* The cursor will remain "Busy" when saving fonts while you do other stuff in the background.
* Versions from 5.0 through 7.0 allows you to save all unaltered opened fonts from the menu (**File: Save All**) but not in the Standard toolbar. In double-byte versions of Windows, the system may display a critical error saying "List index out of bounds (0)". Single-byte versions of Windows does nothing.
* If you exit the program, it may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program displays the "Access violation" when closing after doing some operations – the font(s) may be invalid.
* Any glyph stored in the clipboard will have either "Glyph Contours" or "Glyph Data".
* The menu item **Edit: Delete** is not dimmed on startup or when closing other dialogs.
* Complete Composites slows down the first time using in simple and composite glyphs.
* Versions from 5.0 through 6.0 makes **Complete Composites** dimmed in empty glyph(s).
* Versions from 1.0 through 7.0 does not support unmapped glyph(s) or glyph(s) with Unicode SMP mapping(s) in the preview toolbar.
* The postscript name generation and additions to preview toolbar in versions 5.0 through 6.5 only supports glyphs with a Windows Unicode BMP mapping.
* The program displays a critical error if you use Complete Composites in some glyphs in the Private Use Area. After that, these glyphs cannot be recovered. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html), UK has assigned code points in the Private Use Area for different glyphs in his fonts, notably low profile diacritics and small capitals. Rebecca G. Bettencourt / [Kreative Korp](http://www.kreativekorp.com/) has assigned code points in the Private Use Area for different glyphs in her fonts, notably extended block elements.
* If you want to change resources in versions containing a non-standard resource layout, you would have to use Resource Tuner (tested with latest version) or UPX (tested with the DOS version of 2.01 running on a DOS session with Windows XP Pro SP3 - this version dates from about 2006 and was distributed with FreeDOS) to unpack the executable file which isn't possible as UPX halts with "not packed by UPX".
* In new fonts, the Euro (€) doesn't have a Macintosh Roman mapping but the international currency sign (¤) does have it.
* The euro (€) and international currency sign (¤) use the same mapping in the Macintosh Roman glyph mapping list.
* Versions from 1.0 through 6.5 only has one icon for the executable file.
* Versions from 1.0 through 6.5 use ISO Latin-1 as the output encoding. East Asian users (e.g. Korean) will appreciate in previewtext.dat substitutes accented letters by ASCII counterparts, e.g. é by e and if kerning pairs are exported, instead of having &lt;&lt; for « you have to use \\00AB as escape code.

## Unregistered version limitations
The unregistered version works for 30 days with the following limitations based on the major version number.
* 3.0 - It shows a nag screen when pressing Start.
* 4.0 - It shows a nag screen when it is expired.
* 5.0 and 5.6 - It disables certain features like saving fonts after expiration and executing it five times.
* 6.0 and above - It disables certain features like saving fonts (not projects) and automatic hinting in font etsting.
* 7.0 - It creates subsetted versions when saving, testing, exporting or installing fonts.

Under the Help menu is an item labeled Register and in the Tip of the Day is a button with the same label when this executed a screen will pop up giving the registration code.

## User Data (Glyph Transformer scripts and Unicode data files omitted)
* **bookmarks.txt** – Created automatically after exit. Includes bookmarks used in the glyph overview window for each Unicode codepoint.
* **CompositeData.xml** – Located in the Composite folder as used by **Complete Composites**.
* **CurrentTransformProgram.xml** – Created when opening a Transform Program in the Glyph Transformer. If removed, this window appears blank.
* **FC#####.ttf** – Contains a temporary font used when the Test Font Window is opened (##### is five numbers). The font name in version 3.0 through 6.5 is FC Test Font ###### (###### is six numbers).
* **fcppreview.txt** – For old versions of FontCreator, includes the text used in the Test Font Window. The text is restored to factory defaults if removed. (See previewtext.dat in recent versions)
* **fntXX.tmp** – Used when saving fonts (XX is a letter and number combo).
* **FontCreatorSetup.exe** – Used to reinstall the program (the download is also available on the High-Logic website).
* **FontCreator.tip** – Contains the tips in the Tip of the Day Window. If removed, this window appears blank.
* **glyphnames.dat** – For versions 7.0 and newer, contains the default glyph names when opening existing fonts and when you generate glyph names on the Glyph Properties dialog. Before that, it includes the same list but **xi** assigns a codepoint of U+0000.
* **guidelines.dat** – Created automatically after exit. Includes guidelines used in Glyph Edit window and Guideline Options.
* **kern_filename.txt** – For old versions of FontCreator, stores the legacy kerning pair data for each font whereas filename is the name of each font.
* **previewtext.dat** – For versions 3.0 through 6.0, controls the text used in Test Font Window. Text in TFONTTESTFORM is restored to factory defaults if removed.
* **preview.txt** – For version 7.0 and newer, contains the standard preview texts for the Preview toolbar. The dropdown list appears blank if removed.
* **SubFamily.dat** – Includes naming fields for different languages.
* **TableOffsetOrder.dat** – Contains the tables supported by any existing fonts. All tables are moved to Unsupported if removed.
* **tags.txt** – For versions 7.0 and newer, controls the names of the five tags that can be assigned to each glyph.

## Registry Keys

### AddCharacters
* **SelectedCharacter** – Character used in the **Insert Characters** dialog. Default is U+0000 NULL.
* **SelectedFont** – Font used in the **Insert Characters** dialog. Default is **Arial Unicode MS**.

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
* **ShowUserDefinedGuidelines** – Used when pressing **Show Guidelines** in Guidelines Options or in the Grid toolbar. If Microsoft Narrator is running, the checkbox in the Guidelines Options window will read the ampersand.
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
* **InstallFontsInFontsFolder** – This corresponds to the **Install the font in Windows Fonts folder** option in the Font Installation Wizard. Default is on. On Windows Vista and above, this option requires administrator privileges.

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

### Kerning (Version 3.0 through 6.5)
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
* **RemoveDSIGTable** – This corresponds to the **When Opening Font Files: Remove DSIG table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.5 only)
* **RemoveHdmxTable** – This corresponds to the **When Opening Font Files: Remove hdmx table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.5 only)
* **RemoveLTSHTable** – This corresponds to the **When Opening Font Files: Remove LTSH table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.5 only)
* **RemoveVDMXTable** – This corresponds to the **When Opening Font Files: Remove VDMX table** option in the Font tab. If enabled, this table is removed. If disabled, this table is kept. (Available in version 5.5 through 6.5 only)
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
The program is unregistered if this key is removed.
* **V5D#** – Created when registering the program whereas # is a numerical string. It displays a message and removes the **Register** item on the Help menu and button in **TTIPOFTHEDAYFORM**. Version 6.0 and newer places your name on the title bar.

### Themes
* **ActiveTheme**

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

## Cursors in the executable file (Delphi resources omitted)
* **CZCANCEL** – Used when canceling actions. This resource uses the Argentinian Spanish language.
* **CZMOVE** – Used by the **Hand** feature. This resource uses the Argentinian Spanish language.
* **HLADDCONTOUR** – Used when adding contours.
* **HLDUPLICATE** – Used when duplicating contours.
* **HLFREEHAND** – Used by the **Freehand** feature in the Drawing toolbar
* **HLGUIDELINED** – Used by the **Guideline** feature in the Drawing toolbar
* **HLKNIFE** – Used by the **Knife** feature in the Drawing toolbar. This resource uses the German language.
* **HLMEASURE** – Used by the **Measure** feature in the Drawing toolbar
* **HLMOVECONTOUR** – Used when moving contours. This resource uses the German language.
* **HLMOVEPOINT** – Used when moving points. This resource uses the German language.
* **HLNEWELLIPSE** – Used by the **Ellipse** feature in the Drawing toolbar
* **HLNEWRECTANGLE** – Used by the **Rectangle** feature in the Drawing toolbar
* **HLROTATE** – Used by the **Rotate** feature in the Drawing toolbar. This resource uses the German language.
* **HLSELECT** – Used when selecting anything. This resource uses the German language.
* **HLSELECTCONTOUR** – Used when selecting contours. This resource uses the German language.
* **HLSELECTPOINT** – Used when selecting points. This resource uses the German language.
* **HLZOOMIN** – Used by the **Zoom In** feature in the Drawing toolbar. This resource uses the German language.
* **HLZOOMOUT** – Used by the **Zoom Out** feature in the Drawing toolbar
* **RV_JUMP_CURSOR** – Inverted jump cursor
* **VT_HEADERSPLIT** – No meaning
* **VT_MOVEALL** – Used when moving contours in simple glyphs.
* **VT_MOVEE** – Used when moving contours in simple glyphs.
* **VT_MOVEEW** – Used when moving contours in simple glyphs.
* **VT_MOVEN** – Used when moving contours in simple glyphs.
* **VT_MOVENE** – Used when moving contours in simple glyphs.
* **VT_MOVENS** – Used when moving contours in simple glyphs.
* **VT_MOVENW** – Used when moving contours in simple glyphs.
* **VT_MOVES** – Used when moving contours in simple glyphs.
* **VT_MOVESE** – Used when moving contours in simple glyphs.
* **VT_MOVESW** – Used when moving contours in simple glyphs.
* **VT_MOVEW** – Used when moving contours in simple glyphs.

## Bitmaps in the executable file (Delphi resources omitted)
* **HLCSPINDOWN** – Used in the spinner control.
* **HLCSPINUP** – Used in the spinner control.
* **RZCMBOBX_DEVICE** – Used in the font dropdown list.
* **RZCMBOBX_FIXEDPITCH** – Used in the font dropdown list.
* **RZCMBOBX_PRINTER** – Used in the font dropdown list.
* **RZCMBOBX_TRUETYPE** – Used in the font dropdown list.
* **RZCMBOBX_TRUETYPEFIXED** – Used in the font dropdown list.
* **SPTBXGLYPHS** – Used by glyphs in the Glyph Overview. This resource uses the Argentinian Spanish language.
* **TB2SYSMENUGLYPHS** – Used by the toolbars.
* **TBXGLYPHS** – Used by glyphs in the Glyph Overview.
* **TBXSYSMENUIMAGES** – Used by the toolbars.
* **TCOLORSELECTOR** – Used in the color selection dialog.
* **VT_CHECK_DARK** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_CHECK_LIGHT** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_FLAT** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_MOVEALL** – Cursor used for scrolling.
* **VT_MOVEEW** – Cursor used for scrolling.
* **VT_MOVENS** – Cursor used for scrolling.
* **VT_TICK_DARK** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_TICK_LIGHT** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_UTILITIES** – Additional arrows.
* **VT_XP** – Used for radio buttons, checkboxes and dropdown lists.
* **VT_XPBUTTONMINUS** – No meaning
* **VT_XPBUTTONPLUS** – No meaning

## RCData's in the executable file
* **DESCRIPTION** – This data is binary.
* **DVCLAL** – This data is binary.
* **PACKAGEINFO** – This data is binary.
* **TABOUTFORM** – Used by **Help: About...**. The dialog resembles the one used in Windows. The default push button is **OK**.
* **TADDCHARACTERSFORM** – Used when adding characters to the font. In the dialog, Sorted is checked by default according to the **Go to Unicode Block** form.
* **TADDCHARACTERTOGLYPHINDEXMAPPINGFORM** – Displays a dialog when you press **Select** in **TCHARACTERTOGLYPHINDEXMAPPINGFORM**. It allows you to select Unicode values for each glyph. The default push button is **OK**.
* **TADDGASPFORM** – Used when adding a gasp range to the font. The default push button is **OK**.
* **TADDLOCALLANGUAGEDATAFORM** – Used when adding language data to the font. The default push button is **OK**.
* **TADDPLATFORMFORM** – Used when pressing the **Add** button in the Platform Manager (this adds a platform to the font). The default push button is **OK**. The **Help** button does nothing in old versions.
* **TADVANCEDEDITFORM** – Used when editing a naming field in the font. The default push button is **OK**.
* **TADVANCEDNAMINGFORM** – For versions 3.0 through 6.0 only, used when including additional naming fields for a font. The default push button is **OK**. See TFONTPROPERTIESFORM in recent versions.
* **TAUTOKERNINGFORM** – Used when automatically adding kerning pairs to the legacy kerning tables. The default push button is **Next**.
* **TAUTOMETRICSFORM** – Used when automatically generating metrics for glyphs. The default push button is **Next**.
* **TAUTONAMEFORM** – Used when automatically changing the naming fields of a font. The default push button is **Next**.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** – The default push button is **OK**.
* **TCODEPAGERANGEFORM** – Displays a dialog where you can enable or disable which encoding to support in the font. The default push button is **OK**.
* **TCOLORFORM** – It's not the standard Windows color selection dialog.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Used when modifying the properties of each composite glyph member. The default push button is **OK**.
* **TCONVERTBITMAPTOCONTOURSFORM** – Used when importing bitmap files to convert into contours. The default push button is **OK**.
* **TDISABLEDFORM** – For unregistered copies of FontCreator, displays this form when trying to save/test/install fonts or extract TrueType font collections or when pressing Use Evaluation Version in the splash screen reminding that the trial period is exceeded.
* **TDM** – This data is binary.
* **TEXPORTGLYPHDATAFORM** – Used when exporting glyph data. The default push button is **OK**.
* **TEXTRACTFROMTTCFORM** – Used by **Tools: Extract from TTC...** to extract TrueType font collections. The default push button is **Next**. (See TDISABLEDFORM for the used form when the trial period is exceeded or using unregistered recent versions)
* **TFINDFORM** – Used when searching parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** – Used when setting embedding and licensing rights in the font. The default push button is **OK**.
* **TFONTHEADERFLAGSFORM** – Used when setting the header flags in the font. The default push button is **OK**.
* **TFONTINSTALLWIZARDFORM** – Used when installing the font for use with other applications. The default push button is **Next** or **Finish**. The path for Arial font in "dummy will be located at" is displayed in lowercase. In Windows Vista and up, the Install button includes an icon to show the UAC prompt. (See TDISABLEDFORM for the used form when the trial period is exceeded or using unregistered recent versions)
* **TFONTOVERVIEWFORM** – Shows all glyphs available in the font after opening one or more font(s).
* **TFONTPROPERTIESFORM** – Used when viewing the font properties. The default push button is **OK**.
* **TFONTSETTINGSFORM** – Displays a dialog where you can change various settings for the font. The default push button is **OK**.
* **TFONTTABLESFORM** – Displays a dialog where it shows a full list of tables in the font. The default push button is **OK**.
* **TFONTTESTFORM** – Used when testing the opened font. Version 3.0 has a dropdown list to choose the encoding, which this is implemented with Windows 95. The Sample Text list in versions 5.0 through 6.0 is predefined and cannot be edited. Printing in version 3.0 through 6.0 only supports the Basic Latin range of Unicode while other characters are printed with a system font. Version 7.0 and newer displays the font name in square brackets with numbers at the end. (See TDISABLEDFORM for the used form when the trial period is exceeded or using most unregistered old versions)
* **TGASPFORM** – Used when managing gasps in the font. The default push button is **OK**.
* **TGENERATECONTOURSCANCELFORM** – The default push button is **Cancel**.
* **TGENERATEPROBLEMREPORTFORM** – Used when pressing **Next** in the Glyph Validation Wizard. The problem report is "Report". The default push button is **OK**.
* **TGLYPHALREADYMAPPEDFORM** – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do. The default push button is **Yes**.
* **TGLYPHEDITFORM** – Used when opening glyphs from the Font Overview.
* **TGLYPHPROPERTIESFORM** – For old versions of FontCreator, displays a dialog where you can change various properties for the selected glyph. Pressing Alt-Enter opens up this form without reading when a screen reader is running. The **Help** button does nothing in old versions.
* **TGRIDFORM** – Used when changing grid settings. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TGUIDELINEMODIFYFORM** – Used when modifying guidelines. The default push button is **OK**.
* **TGUIDELINESFORM** – Used when changing guideline settings. The default push button is **OK**. The **Help** button does nothing in old versions.
* **THLCREGISTERABOUTBOXDLG** – Non-standard About box for old versions only.
* **TIMPORTGLYPHDATAFORM** – Used when importing glyph data. The default push button is **OK**.
* **TINSERTGLYPHFORM** – Used when inserting glyphs. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TINSTALLEDFONTSFORM** – Displays a dialog to open installed fonts in the computer. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TKERNINGFORM** – For old versions of FontCreator, displays a dialog where you can view or edit the legacy kerning tables in the font. See the OpenType Designer in recent versions to edit the GPOS kerning tables.
* **TKERNINGNEWPAIRFORM** – Used when adding a kerning pair in the legacy kerning tables. The default push button is **OK**.
* **TMAINFORMFCP3** – Version 3.0 only. Used when starting FontCreator. Maximizing each window changes the title bar. (See TMAINFORMFONTCREATOR in recent versions)
* **TMAINFORMFONTCREATOR** – Used when starting FontCreator. Maximizing each window changes the title bar.
* **TMETRICSFORM** – Used when configuring metrics options. The default push button is **OK**.
* **TNAMINGFORM** – For versions 3.0 through 6.0 only, displays a dialog where you can manually change the naming fields of a font. The default push button is **OK**. See TFONTPROPERTIESFORM in recent versions.
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font. The default push button is **OK**.
* **TOPTIONSFORM** – Displays a dialog where you can set a plethora of FontCreator options. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TPASTESPECIALFORM** – Used when pasting data for glyphs in the clipboard. The default push button is **OK**. In the Items list (versions 5.5 through 6.0 only), Glyph Outline Data and Glyph Metrics (i.e. the first two items) are checked by default.
* **TPCLTFORM** – For versions 3.0 through 6.5 only, displays a dialog where you can include the old PCL5 data for legacy printers. The default push button is **OK**.
* **TPERFORMTRANSFORMATIONFORM** – For versions 5.6 and newer, displays the Glyph Transformer. The default push button is **OK**.
* **TPLATFORMMANAGERFORM** – For version 2.0 through 6.5 only, displays a dialog where you can choose which platform to support in the font. The default push button is **OK**.
* **TPOSTSCRIPTNAMESFORM** – Used when changing PostScript names for glyphs in the font. The default push button is **OK**.
* **TPRINTABORTFORM** – Used when canceling the font printing process.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing a glyph.
* **TPROGRESSFORM** – Progress window. The cursor for this form is **Busy**. The default push button is **Cancel**.
* **TREGISTERFORM** – For unregistered copies of FontCreator, displays a dialog where you can enter the registration code (**Help: Register**). This removes the splash screen on startup and enables several disabled features in some versions.
* **TRESOURCEEDITORDLG** – In old versions only, used when editing resources.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Used when adding glyph members to a composite glyph. The default push button is **OK**.
* **TSHAREWAREFORM** – For old versions and unregistered copies of FontCreator, displays this notice when pressing **Start** on the splash screen after the trial period is exceeded. (Only in old versions)
* **TSORTGLYPHSFORM** – Used when changing the glyph order within a font. The default push button is **OK**.
* **TSPLASHFORM** – Displays this form on startup when the Reg key is not found. The three buttons at the bottom are displayed in random order. If the trial period is exceeded, when starting the program five times it displays a random paragraph.
* **TTIPOFTHEDAYFORM** – Used for newcomers and also in **Help: Tip of the Day**. FontCreator.tip will be used to display tips. On unregistered copies is a button labeled **Register** and in the Help menu is a menu item with the same text. If removed when not registered, it displays the "Access Violation".
* **TTRANSFORMFORM** – For simple glyphs only. The default push button is **Apply**.
* **TUNICODERANGEFORM** – Used when specifying the Unicode blocks or ranges encompassed by the font file in the mappings for double-byte platforms. The default push button is **OK**.
* **TUPDATEREMINDERFORM** – Used when the program checks for updates as if **OnStartupShowUpdateReminder** is enabled. The default push button is **OK**.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph. The default push button is **OK**.
* **TVALIDATIONWIZARDFORM** – Displays a dialog where you can validate the font for errors. The default push button is **Next**.
* **TWARNINGFORM** – Used for warnings. (See also TWIDEWARNINGFORM in new versions)
* **TWELCOMEFORM** – Used for newcomers as if **OnStartupShowWelcome** is enabled. The default push button is **OK**.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** – Used for warnings, replaces TWARNINGFORM in old versions.
