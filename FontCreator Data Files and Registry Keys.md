## Notes
* The cursor will remain "Busy" when saving fonts while you do other stuff in the background.
* All versions allows saving all unaltered opened fonts from the menu (**File: Save All**) but not in the Standard toolbar. In double-byte versions of Windows, the system displays a critical error saying "List index out of bounds (0)".
* If you exit the program, it may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program displays the "Access violation" when closing after doing some operations – the font(s) may be invalid.
* Any glyph stored in the clipboard will have either "Glyph Contours" or "Glyph Data".
* The menu item **Edit: Delete** is not dimmed on startup or when closing other dialogs.
* Complete Composites (when generated from `CompositeData.xml` but not auto or anchor based) slows down the first time using in simple and composite glyphs.
* Version 5.0 until 6.0 makes **Complete Composites** dimmed in empty glyphs.
* Version 1.0 until 7.0 does not support unmapped glyph(s) or glyph(s) with Unicode SMP mapping(s) in the preview toolbar.
* The postscript name generation and additions to preview toolbar in versions 5.0 through 6.5 only supports glyphs with a Windows Unicode BMP mapping.
* The program displays a critical error if you use Complete Composites in some glyphs in the Private Use Area. After that, these glyphs cannot be recovered. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html), UK, the guy behind the font samples and his fonts created by the same program, has assigned code points in the Private Use Area for different glyphs in his fonts, notably low profile diacritics and small capitals. Rebecca G. Bettencourt / [Kreative Korp](http://www.kreativekorp.com/), the girl behind Bits'n'Picas, her fonts released under a custom license and other stuff has assigned code points in the Private Use Area for different glyphs in her fonts, notably extended block elements.
* If you want to change resources in versions containing a non-standard resource layout (tested with version 5.6), you would have to use [Resource Tuner](http://www.heaventools.com/resource-tuner.htm) (tested with version 2.20) or [UPX](https://upx.github.io/) (tested with version 2.01 for DOS running Windows XP Pro K SP3 32-bit - this version was released in 2006 and distributed with FreeDOS) to unpack the executable file which isn't possible as UPX says it's not packed.
* In new fonts, the Euro (€) doesn't have a Macintosh Roman mapping but the international currency sign (¤) does have it.
* The euro (€) and international currency sign (¤) use the same mapping in the Macintosh Roman glyph mapping list.
* Version 1.0 until 5.6 use ISO Latin-1 as the output encoding. East Asian users (e.g. Korean) will appreciate in `previewtext.dat` substitutes accented letters by ASCII counterparts, e.g. é by e and when exporting kerning pairs, instead of having &lt;&lt; for « you have to use \\00AB as escape code.

## Unregistered version limitations
As FontCreator is released as pay shareware, the unregistered version works for 30 days with the following limitations based on the version number.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) – After a grace period of 30 days, the program will show a nag screen when pressing **Start**. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 4.5 (2004-08-17) – After a grace period of 30 days, the program cannot be used at all until the registration process is started.
* 5.0 (2005-01-12) until 5.6 (2007-07-19) – After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where e.g. fonts cannot be saved or tested.
* 6.0 (2009-06-17) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) – The program will enter a reduced functionality mode, where e.g. tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) – The program will create subsetted versions when saving, testing, exporting or installing fonts.
* 12.0.0.2543 (2019-07-10) until 12.0.0.2547 (2019-09-12) – The program will add watermarks when generating fonts.

Under the Help menu is an item labeled **Register** when this executed a screen will pop up giving the registration code.

## Windows version compatibility
* Windows Vista and later – 12.0.0.2547
* Windows XP – 10.0
* Windows 2000 – 7.0
* Windows 95, 98, ME and NT 4.0 – 6.0.1

## User Data (Glyph Transformer scripts and Unicode data files omitted)
FontCreator uses several data files for advanced settings and customizations. Normally most files are stored in a system folder and owned by trusted installer where they cannot be changed. If you want to edit most files directly they either must have administrative privileges or change the owner to users (this can be done with `takeown` or **Security: Advanced** in the file properties).

* **bookmarks.txt** – Created automatically after exit. Includes bookmarks used in the glyph overview.
* **CompositeData.xml** – Located in the Composite folder as used by **Complete Composites**.
* **CurrentTransformProgram.xml** – Created when opening a Transform Program in the Glyph Transformer. If removed, this window appears blank.
* **FC#####.ttf** – Temporary font used by `TFONTTESTFORM` (##### is five numbers). The font name in version 3.0 through 6.5 is FC Test Font ###### (###### is six numbers).
* **fc12.cfg** – Configuration file used by FontCreator.
* **fcppreview.txt** – For old versions of FontCreator, includes the text used in the Test Font Window. The text is restored to factory defaults if removed. (See `previewtext.dat` in recent versions)
* **fntXX.tmp** or **fntXXX.tmp** – Temporary font used for saving (XX or XXX are letter and number combos).
* **FontCreatorSetup.exe** – Used to reinstall the program (the download is also available on the High-Logic website with a form to enter your name and email address or with the link to the direct download).
* **FontCreator.tip** – Contains the tips in the Tip of the Day Window. If removed, this window appears blank.
* **glyphlist.dat** – Contains the Adobe glyph list. Old versions have the same list but duplicates **xi** to U+0000.
* **glyphnamesnew.dat** – For version 7.0 and above, contains the default glyph names when opening existing fonts and when you generate glyph names on the Glyph Properties dialog. Prior to FontCreator 12 another file (`glyphnames.dat`) was used, but that one is now obsolete.
* **guidelines.dat** – Created automatically after exit. Includes guidelines used in Glyph Edit window and Guideline Options.
* **kern_filename.txt** – For old versions of FontCreator, stores the legacy kerning pair data for each font whereas `filename` is the font name.
* **previewtext.dat** – For version 3.0 until 6.0, controls the text used in Test Font Window. Text in `TFONTTESTFORM` is restored to factory defaults if removed.
* **preview.txt** – Contains the standard preview texts for the Preview toolbar. The dropdown list is shown as blank if removed.
* **SubFamily.dat** or **SubFamily2.dat** – Includes multilanguage naming fields.
* **TableOffsetOrder.dat** – Contains the tables supported by any font. All tables are moved to Unsupported if removed. Newer versions changed it to a text file and adds another file named `TableOffsetOrderCFF`.
* **tags.txt** – For version 7.0 and above, controls the names of the five tags that can be assigned to each glyph.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** when pressed the program will either copy most files to the user data folder or open it.

## Registry Keys

### AddCharacters (used in `TADDCHARACTERSFORM`)
* **SelectedCharacter** – Used to select the character. Default is beginning of Basic Latin Unicode block.
* **SelectedFont** – Used to change the font. Default is **Arial Unicode MS**.

### Background
* **BackgroundInitColor** – Select the color for the background. Default is white.
* **BackgroundInitScale** – Select the scaling factor for the background.

### Columns
* **Open Installed Fonts** – Binary value used by `TINSTALLEDFONTSFORM`.

### Externals
There are three built-in external programs: Fonts Folder, Character Map and MainType (if installed).
* **Location#** – The last character can be up to digit three. Default is empty.
* **Title#** – The last character can be up to digit three. Default is **External #** whereas # is a number.

### Find (used in the Find dialog)
* **FindLanguageID** – Used by any language.
* **PlatformID** – Used to find the **Platform** in the Mapping tab.
* **PlatformSpecificEncodingID** – Used to change the specific encoding for **Platform** in the Mapping tab.
* **TabIndex** – Used to change the tab.

### FontOverview
* **CategoryWidth** – Select the width used for categories in the font overview.

### Fonts (used in Options: Font)
* **ExportDecomposeScaled** – Used with **Export Font: Decompose composite glyphs with scaled components**. Default is on.
* **ExportExcludeLegacy** – Used with **Export Font: Exclude legacy data**. Default is on.
* **FontEnableOpenContours** – Used with **Special Features: Enable open contours**. Default is on.
* **OpenFriendlyGlyphNames** – Used with **Open Font: Generate friendly glyph names**. Default is on.

### FreeDraw (used in Free Draw)
* **BrushWidth** – Used to change the **Brush width**.

### Glyph Edit Window
* **FilledOutline** – Used with **Fill Outline** in the Grid toolbar.
* **ShowConnectionBetweenPoints** – Used with **Show Connection** in the Grid toolbar. Default is on.
* **ShowFirstAndLastPointIndicators** – Used with **Show First and Last** in the Grid toolbar. Default is on.
* **ShowToolbarWindowBackground** – Enables or disables the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Enables or disables the kerning window. Default is off.
* **ShowToolbarWindowPalette** – Used with **Palette** in the toolbar right click context menu.
* **ShowToolbarWindowTransformation** – Used with **Transformation** in the toolbar right click context menu. Default is on.
* **ShowToolbarWindowValidation** – Used with **Show Report** in the Glyph toolbar. Default is off.

### Grid
* **FixedGridColor** – Used with **Color** in Grid Options. Default is white.
* **FixedGridLineStyle** – Used with **Line style** in Grid Options. Default is solid.
* **GridColor** – Used with **Color** in Grid Options. Default is sky blue.
* **GridDistance** – Used with **Mininum distance between grid points in units** in Grid Options.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in Grid Options.
* **GridLineStyle** – Used with **Line style** in Grid Options. Default is solid.
* **IncludeBaseline** – Used with **Baseline** in Metrics Options. Default is on.
* **IncludeLeftSideBearing** – Used with **Left side bearing** in Metrics Options. Default is on.
* **IncludeRightSideBearing** – Used with **Right side bearing** in Metrics Options. Default is on.
* **IncludeTypoAscender** – Used with **TypoAscender** in Metrics Options. Default is off.
* **IncludeTypoDescender** – Used with **TypoDescender** in Metrics Options. Default is off.
* **IncludeWinAscent** – Used with **Win Ascent** in Metrics Options. Default is on.
* **IncludeWinDescent** – Used with **Win Descent** in Metrics Options. Default is on.
* **IncludexHeight** – Used with **x-Height** in Metrics Options. Default is on.
* **IncludeYAxis** – Used with **Y-Axis** in Metrics Options. Default is on.
* **LockUserDefinedGuidelines** (version 4.5 & above) – Used when pressing **Lock Guidelines** in the Grid toolbar. Default is off.
* **ShowBearings** (version 5.6 & above) – Used when pressing **Show Metrics** in the Grid toolbar. Default is on.
* **ShowFixedGridLines** (version 5.6 & above) – Used with **Show reference lines at x = 0, y = 0** in Grid Options.
* **ShowGrid** – Used when pressing **Show Grid** in Grid Options or in the Grid toolbar. Default is on.
* **ShowUserDefinedGuidelines** – Used when pressing **Show Guidelines** in Guidelines Options or in the Grid toolbar. If Microsoft Narrator is running, the checkbox in the Guidelines Options window will read the ampersand. Default is on.
* **SnapToGrid** (version 4.5 & above) – Used when pressing **Snap to Grid** in the Grid toolbar. Default is off.
* **SnapToUserDefinedGuidelines** (version 4.0 & above) – Used when pressing **Snap to Guidelines** in the Grid toolbar. Default is off.

### GUI
* **UpdateCheckInterval** – Includes the date used to check the last update when **OnStartupShowUpdateReminder** is enabled.

### GuideLines (used in Guideline Options)
* **Color** – Default is black.
* **LineStyle** – Default is solid.

### ImportImage
* **BitmapPositionOrigin** – Used with radio buttons in the Glyph: Position option. (Available in Import Image)
* **BitmapPositionType** – Set the Bitmap Position Type.
* **Erode** – Used with **Erode – Dilate** in the Image tab. Default is No filter. (Available in Import Image)
* **GlyphPositionX** – Used with **Position: X position** in the Glyph tab. (Available in Import Image)
* **GlyphPositionY** – Used with **Position: Y position** in the Glyph tab. (Available in Import Image)
* **ImportMode** – Used with **Import Mode** in the Glyph tab. Default is Trace. (Available in Import Image)
* **InvertBitmap** – Used with **Negative** in the Image tab. Default is off. (Available in Import Image)
* **MinimumPointsInContour** – Set the number of Minimum Points in the contour.
* **Multiplier** – Used with **Size: Multiplier** in the Image tab. (Available in Import Image)
* **SmoothFilter** – Used with **Smooth Filter** in the Image tab. Default is Smooth. (Available in Import Image)
* **Threshold** – Used with **Threshold** in the Image tab. Default is 150. (Available in Import Image)

### Install (used in `TFONTINSTALLWIZARDFORM`)
* **InstallFontsInFontsFolder** – In old versions only; used with **Install the font in Windows Fonts folder**. Default is on. On Windows Vista and above, this option requires administrator privileges.

### InstalledFonts (used in `TINSTALLEDFONTSFORM`)
* **PreviewHeight** – Select the height used for the preview area.

### Interface (used in the toolbar context menu or View: Toolbars)
* **LockToolbars** – Used with **Lock Docked Toolbars**. Default is off.
* **ShowUserNotes** – Used with **Show User Notes**. Default is off.

### Interface Settings
* **ChildWindowState**
* **CompleteCompositesAction** – Used with **Complete Composites** button in the toolbar. Default is **Auto**.
* **CustomNamingShowOutputContent**
* **GlyphCaptionAuto** – Used with **Captions: Automatic** in the right-click context menu of font overview.
* **GlyphCaptionType2** – Used with the Captions options in the right-click context menu of font overview.
* **GlyphDrawMode** – Select the mode to draw contours on each glyph.
* **GlyphFillAlpha** – Used with **Fill Outline** in the View menu.
* **GlyphNamesHistoryReplace** – Contains the history of postscript names to replace.
* **GlyphNamesHistorySearch** – Contains the history of postscript names to find.
* **GlyphNamesOptionsCS**
* **GlyphNamesOptionsRE**
* **GlyphOutlineFillMode** – Used with **Glyph outline fill mode** in the Options: General tab.
* **GlyphPropsExpanded**
* **GroupManagerSorted** – Used to sort the group manager.
* **KerningFolderExport** – Directory for exporting the legacy kerning tables.
* **KerningFolderImport** – Directory for importing the legacy kerning tables.
* **NewFontIncludeOutlines** – Used with **Predefined outlines: Include outlines** in the new font dialog. Default is on.
* **OpenDialogInitialDir2** – Directory used in the Open dialog.
* **OpenDialogInitialDirAutoKerning** – Directory used in the AutoKern Open dialog.
* **OpenDialogInitialDirImportImage** – Directory used in the Import Image Open dialog.
* **OpenDialogInitialDirNamingField** – Directory used in the Edit Naming Field Open dialog.
* **OpenDialogInitialDirTransform** – Directory used in the Glyph Transformer Open dialog.
* **OptionsPage** – Select the tab used in the Options dialog.
* **OTLFDesignerCollapsedFeatures** – Select the features to collapse in the OpenType Designer.
* **OTLFDesignerCollapsedLookups** – Select the lookups to collapse in the OpenType Designer.
* **OTLFDesignerCollapsedScripts** – Select the scripts to collapse in the OpenType Designer.
* **OTLFDesignerPreviewLanguage** – Contains the language used for the preview text in the OpenType Designer.
* **OTLFDesignerPreviewSampleText** – Contains the sample text used for the preview text in the OpenType Designer.
* **OTLFDesignerPreviewScript** – Contains the script used for the preview text in the OpenType Designer.
* **OTLFEditor** – Stores the settings used in the OpenType script editor.
* **OverviewColCat**
* **OverviewFontZoom** – Contains the zoom factor used in the glyph overview.
* **OverviewGridZoom** – Contains the grid zoom factor used in the glyph overview.
* **OverviewSampleFont** (version 4.0 & above) – Used with **Font Overview: Font used in cells** in the View tab. Default is **Arial**. Empty strings displays the preview with **MS Sans Serif** with the characters in a different position. (Available in the Options window)
* **OverviewShowCaption** – Used with **Font overview: Show caption** in the Overview tab. Default is on. (Available in the Options window)
* **OverviewShowSample** – Used with **Font Overview: Show sample in empty glyphs** in the Overview tab. Default is on. (Available in the Options window)
* **OverviewSingleHeight** – Used with **Font overview: Glyph height** in the Overview tab. Default is 48. (Available in the Options window)
* **OverviewSingleWidth** – Used with **Font overview: Glyph width** in the Overview tab. Default is 70. (Available in the Options window)
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** in the Overview tab. (Available in the Options window)
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUseColor** – Used with **Font overview: Use type color in glyph caption** in the Font tab. Default is on. (Available in the Options window)
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** in the General tab. Default is blank.
* **SampleSingleHeight** – Used with **Samples Toolbar: Glyph height** in the Sample tab. Default is 55. (Available in the Options window)
* **SampleSingleWidth** – Used with **Samples Toolbar: Glyph width** in the Sample tab. Default is 62. (Available in the Options window)
* **SaveDialogInitialDirNew2** – Contains the initial directory used in the save dialog.
* **SelectCompositeCaptionType**
* **SelectCompositeFontZoom** – Contains the zoom factor used in the select composite glyph window.
* **SelectCompositeGridZoom** – Contains the grid zoom factor used in the select composite glyph window.
* **SettingsPage** – Select the tab used in the Settings dialog.

### Kerning
* **AutoKerningAllowForPositiveKerningValues** – Used with **Additional Options: Allow for positive kerning values** in the AutoKern window.
* **AutoKerningExcludeLowerLower** – Used with **Exclude lowercase-lowercase pairs** in the AutoKern window.
* **AutoKerningExcludeLowerUpper** – Used with **Exclude lowercase-uppercase pairs** in the AutoKern window.
* **AutoKerningUseBaseMetrics** – Used with **Composite glyphs follow base glyphs (use this glyph's metrics)** in the Kern Wizard in OpenType Designer. Default is on.
* **AutoKerningImportFilename** – Used with filename string in the disabled text box.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** in the AutoKern window.
* **AutoKerningReplaceKerning** – Used with **Additional Options: Replace existing kerning when** dropdown box in the AutoKern window.
* **AutoKerningReplacePercentage** – Used with **Additional Options: Replace existing kerning when** slider in the AutoKern window.
* **AutoKerningWhiteSpace** – Used with **Additional Options: White space between characters** in the AutoKern window.
* **KerningColorBackground** – Select the color used for the background. Default is white.
* **KerningColorBaseline** – Select the color used for the baseline. Default is red.
* **KerningColorFirst** – Select the color used for the left glyph. Default is dark blue.
* **KerningColorGridLines** – Select the color used for the Grid Lines. Default is gray.
* **KerningColorSecond** – Select the color used for the right glyph. Default is dark green.
* **KerningShowBaseLine** – Display baseline in Kerning window. Default is on.
* **KerningShowBearingLines** – Display bearing lines in Kerning window. Default is on.
* **KerningShowGridLines** – Display grid lines in Kerning window. Default is on.

### Last Time
* **File_#** – Include fonts used the last time whereas # is a number. When **OnStartupOpenFonts** is enabled, nothing will be opened if removed.

### Metrics
* **AutoMetricsExcludeEmptyGlyphs** – Used with **Additional Options: Exclude empty glyphs (recommended)** in the Automatic Metrics Wizard.
* **AutoMetricsFixedAW** – Used with **Fixed: Change Advance Width** in the Automatic Metrics Wizard.
* **AutoMetricsFixedChangeAW** – Used with **Fixed: Change Advance Width** in the Automatic Metrics Wizard.
* **AutoMetricsFixedChangeLSB** – Used with **Fixed: Change Left Side Bearing** in the Automatic Metrics Wizard.
* **AutoMetricsFixedLSB** – Used with **Fixed: Change Left Side Bearing** spinner in the Automatic Metrics Wizard.
* **AutoMetricsOpticalFactor** – Used with **Glyph spacing factor** in the Automatic Metrics Wizard. Default is 27.
* **AutoMetricsOpticalPreview** – Used with **Preview Text** in the Automatic Metrics Wizard. Default is Preview Text.
* **AutoMetricsOptionIndex** – Used with radio buttons in the Automatic Metrics Wizard.
* **AutoMetricsWhiteSpaceAfter** – Used with **Calculated: White space after characters** in the Automatic Metrics Wizard.
* **AutoMetricsWhiteSpaceBefore** – Used with **Calculated: White space before characters** in the Automatic Metrics Wizard.

### MetricsAndKerning
* **MetricsAndKerningKerningEnabled** – Used by **OpenType Layout Features** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextEnabled** – Used by **Show text before and after glyph** in the Comparison toolbar. Default is off.
* **MetricsAndKerningTextLeft** – Used by **Before** text box in the Comparison toolbar. Default is empty.
* **MetricsAndKerningTextRight** – Used by **After** text box in the Comparison toolbar. Default is empty.

### Most Recently Used Files, Most Recently Used Projects
* **File_#** – Lists the font and project file names in the **File: Reopen** menu (# is a number). The menu will appear dimmed if deleted or if **Clear recent file lists** is selected under this menu.

### OpenType Designer
* **FillGlyphOutlines** – Used with **Colors: Fill glyph outlines** in the OpenType Designer Settings window.
* **GlyphFillColor** – Used with **Colors: Glyph fill color** in the OpenType Designer Settings window.
* **LayoutMode**
* **MarkWidth** – Select the mark width used in the OpenType Designer.
* **PairWidth** – Select the pair width used in the OpenType Designer.
* **PreviewHeight** – Used with preview text height in the OpenType Designer.
* **PreviewSampleFontSize** – Used with preview sample font size in the OpenType Designer.
* **SimpleWidth** – Set the width used in the OpenType Designer.
* **SingleWidth** – Set the width used in the OpenType Designer.
* **TreeWidth** – Select the tree width used in the OpenType Designer.
* **ZoomFactor** – Select the zoom factor used in the OpenType Designer.

### Options
* **AlwaysCreateBackupCopy** – Used with **Create backup copy (bck) on saving a font project** in the Advanced: Settings tab. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in Options: Glyph. Default is on.
* **AutoNamingUseFontRevision** – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in Options: Naming. Default is on.
* **CompressHmtxTable** – Used with **When Saving Font Files: Compress hmtx table** in the Font tab. Default is on. (Available in the Options window)
* **CompressNameTable** – Used with **When Saving Font Files: Optimize name table** in the Font tab. Default is on. (Available in the Options window)
* **DefaultNamingCopyrightIncluded** – Used with **Default Settings for New Fonts: Copyright** in Options: Personalize. Default is on.
* **DefaultNamingCopyrightText** – Used with **Default Settings for New Fonts: Copyright** in Options: Naming. Default is **Typeface © (your company). &lt;year&gt;. All Rights Reserved.**
* **DefaultNamingFontDesignerIncluded** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize.
* **DefaultNamingFontDesignerLinkIncluded** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize.
* **DefaultNamingFontDesignerLinkText** – Used with **Default Settings for New Fonts: Designer URL** in Options: Personalize.
* **DefaultNamingFontDesignerText** – Used with **Default Settings for New Fonts: Designer** in Options: Personalize. Default is empty.
* **DefaultNamingLicenseAgreementIncluded** – Used with **Default Settings for New Fonts: License Agreement** in Options: Personalize.
* **DefaultNamingLicenseAgreementLinkIncluded** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize.
* **DefaultNamingLicenseAgreementLinkText** – Used with **Default Settings for New Fonts: License URL** in Options: Personalize.
* **DefaultNamingLicenseAgreementText** – Used with **Default Settings for New Fonts: License Agreement** in Options: Personalize. Default is empty.
* **DefaultNamingTrademarkIncluded** – Used with **Default Settings for New Fonts: Trademark** in Options: Personalize.
* **DefaultNamingTrademarkText** – Used with **Default Settings for New Fonts: Trademark** in Options: Personalize. Default is **&lt;font family&gt;® Trademark of (your company)**.
* **DefaultPersFontEmbeddingItemID** – Used with **Default Settings for New Fonts: Embedding Lic. Rights** in Options: Personalize.
* **DefaultPersVendorIDText** – Used with **Default Settings for New Fonts: Vendor ID** in Options: Personalize. Default is **HL**.
* **DefaultPersVendorText** – Used with **Default Settings for New Fonts: Vendor** in Options: Personalize. Default is **High-Logic / Made with FontCreator**.
* **DefaultPersVendorURLText** – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize. No default value.
* **DefaultVendorIDIncluded** – Used with **Default Settings for New Fonts: Vendor ID** in Options: Personalize. Default is on.
* **DefaultVendorIncluded** – Used with **Default Settings for New Fonts: Vendor** in Options: Personalize. Default is off.
* **DefaultVendorURLIncluded** – Used with **Default Settings for New Fonts: Vendor URL** in Options: Personalize. Default is off.
* **DefaultZoomFactor** – Used with **Glyph Edit Window: Open with default zoom factor** in Options: View.
* **ExcludeMonospacedFonts** – Used with **When Saving Font Files: Exclude monospaced fonts** in Options: Font. Default is off.
* **IgnoreHintingData** – Used with **When Opening Font Files: Remove hinting data** in Options: Font. Default is off.
* **IgnoreUnsupportedTables** – Used with **When Opening Font Files: Remove unsupported tables** in Options: Font. Default is off.
* **LastUpdateReminderDate** – Includes the date used to check the last update when **OnStartupShowUpdateReminder** is enabled. (See also **UpdateCheckInterval** in the GUI key in recent versions.)
* **LeftSideBearingExcludeLargeFonts** – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in Options: Font. Default is on.
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in Options: Font. Default is on.
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in Options: General. Default is on.
* **OnStartupShowUpdateReminder** – Set this value in the **Startup: Show update reminder** in Options: General to 0 (Never), 1 (Once a year), 2 (Twice a year) or 3 (Once a month). Default is 1 (Once a year).
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in Options: General. Default is on.
* **PanoseValueHexadecimal** – Used with **PANOSE: Value: Show hexadecimal** in Font Properties: Characteristics. Default is off.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in Options: Font. Default is on.
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in Options: Font. Default is off.
* **RemoveDSIGTable** – Used with **When Opening Font Files: Remove DSIG table** in Options: Font. Default is off.
* **RemoveHdmxTable** – Used with **When Opening Font Files: Remove hdmx table** in Options: Font. Default is on.
* **RemoveLTSHTable** – Used with **When Opening Font Files: Remove LTSH table** in Options: Font. Default is on.
* **RemoveVDMXTable** – Used with **When Opening Font Files: Remove VDMX table** in Options: Font. Default is on.
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in Options: Font. Default is on.
* **UnicodeEnabledGUI** (version 5.5 until 6.1) – Used with **Unicode Support: Enable Unicode support for text display and user input** in Options: General. Default is on. If the program is ran under Windows 9x/ME or compatibility mode, the option will appear dimmed.
* **UpdateModifiedDateTimeField** – Used with **Identification: Automatically update modified timestamp when exporting font** in Font Properties: Identification. Default is on.
* **ValueHexadecimal** – Used with **Values: Hexadecimal** in the View: Display Format menu. Default is on. Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in Options: Import.
* **VectorImageEPSOriginX** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in Options: Import.
* **VectorImageEPSOriginY** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in Options: Import.
* **VectorImageEPSPixelsPerEm** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in Options: Import.

### Preview
* **FeaturesWidth** – Contains the width used for OpenType features.
* **FeatureTags** – Contains the tags used for OpenType features. No default value.
* **PreviewFeatures** – Select the features used in the preview text.
* **PreviewFontSize** – Used with size in the Test Font window. Default is 24.
* **PreviewSampleFontSize** – Used with size in the Preview window.
* **PreviewSampleText** – Used with the dropdown box in the Preview window. Default is **High-Logic ©**.
* **PreviewSampleUseKerning** – Used for **Kerning** in the Preview window.
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Used for **Strikeout** in the Test Font window. Default is off.
* **Underline** – Used for **Underline** in the Test Font window. Default is off.

### Reg
The program is started in unregistered mode after installation or if this key is removed.
* **V5D#** – Created after registration whereas # is a numerical string. It displays a message and removes the **Register** item on the Help menu. Version 6.0 and newer places your name on the title bar.

### Themes
* **ActiveTheme** – Contains the active theme.

### Tip of the Day (version 3.0 until 6.0)
* **CurrentTip** – Current line number in `FontCreator.tip`, used when opening the **Tip of the Day** window.
* **ShowTipOnStartup** – In old versions only; used when selecting **Show this screen next time when you start FontCreator** in the **Tip of the Day** window.

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – Used with **Diagonal redundant points detection: Max. off-curve dist.** in Settings: Validation.
* **DiagonalRedundantOnCurvePointsDetection** – Used with **Diagonal redundant points detection: Max. on-curve dist.** in Settings: Validation.
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar.
* **LocalExtremeCoordinatesDetection** – Used with **Off-curve extreme coordinates: Local detection** in Settings: Validation.
* **MaximumRedundantOffCurvePointsDistance** – Used with **Diagonal redundant points detection: Max. off-curve dist.** spinner in Settings: Validation.
* **MaximumRedundantOnCurvePointsDistance** – Used with **Diagonal redundant points detection: Max. on-curve dist.** spinner in Settings: Validation.
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. If enabled, intersecting contours are shown for each glyph. If disabled, no intersecting contours are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. If enabled, warning points are shown for each glyph. If disabled, no warning points are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
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
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in Settings: Validation.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in Settings: Validation.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in Settings: Validation.

### Warn – Default is on for all options
* **WarnBeforeActivatingFixFeature** – Used with **Warn before activating the fix feature in the Font Validation Wizard** in the Advanced tab.
* **WarnBeforeActivatingRemoveFeature** – Used with **Warn before activating a remove feature from the Options → Font page** in the Advanced tab.
* **WarnBeforeAddCharacters** – Used with **Warn before adding characters** in the Advanced tab.
* **WarnBeforeAnchorDelete** – Used with **Warn when deleting anchor** in the Advanced tab.
* **WarnBeforeCloseOpenTypeDesigner** – Used with **Warn about losing changes when cancelling or closing OpenType Designer dialog** in the Advanced tab.
* **WarnBeforeExecutingGlyphTransformProgram** – Used with **Warn before executing Glyph Transformer script** in the Advanced tab.
* **WarnBeforeSortingGlyphs** – Used with **Warn before sorting glyphs** in the Advanced tab.
* **WarnImportSmallImage** – Used with **Warn when importing small image** in the Advanced tab.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts** in the Advanced tab.
* **WarnWhenProcessingVOLTTable** – Used with **Warn when opening a font file which contains a VOLT table** in the Advanced tab.

## Cursors in the executable file (Delphi resources omitted)
* **CZCANCEL** – Used when canceling actions. This resource uses Argentinian Spanish language.
* **CZMOVE** – Used by the **Hand** feature. This resource uses Argentinian Spanish language.
* **HLADDCONTOUR** – Used when adding contours.
* **HLDUPLICATE** – Used when duplicating contours.
* **HLFREEHAND** – Used by **Freehand**
* **HLGUIDELINED** – Used by **Guideline**
* **HLKNIFE** – Used by **Knife**. This resource uses German language.
* **HLMEASURE** – Used by **Measure**
* **HLMOVECONTOUR** – Used when moving contours. This resource uses German language.
* **HLMOVEPOINT** – Used when moving points. This resource uses German language.
* **HLNEWELLIPSE** – Used by **Ellipse**
* **HLNEWRECTANGLE** – Used by **Rectangle**
* **HLROTATE** – Used by **Rotate**. This resource uses German language.
* **HLSELECT** – Used when selecting anything. This resource uses German language.
* **HLSELECTCONTOUR** – Used when selecting contours. This resource uses German language.
* **HLSELECTPOINT** – Used when selecting points. This resource uses German language.
* **HLZOOMIN** – Used by **Zoom In**. This resource uses German language.
* **HLZOOMOUT** – Used by **Zoom Out**
* **RV_JUMP_CURSOR** – Inverted jump cursor
* **VT_HEADERSPLIT** – *No description provided.*
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
* **SPTBXGLYPHS** – Used by glyphs in the Glyph Overview. This resource uses Argentinian Spanish language.
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
* **TADDCHARACTERSFORM** – Used when adding characters to the font. **Sorted** is checked by default according to **Go to Unicode Block**.
* **TADDCHARACTERTOGLYPHINDEXMAPPINGFORM** – Displays a dialog when you press **Select** in **TCHARACTERTOGLYPHINDEXMAPPINGFORM**. It allows you to select Unicode values for each glyph. The default push button is **OK**.
* **TADDGASPFORM** – Used when adding a gasp range to the font. The default push button is **OK**.
* **TADDLOCALLANGUAGEDATAFORM** – Used when adding language data to the font. The default push button is **OK**.
* **TADDPLATFORMFORM** – Used when pressing the **Add** button in the Platform Manager (this adds a platform to the font). The default push button is **OK**. The **Help** button does nothing in old versions.
* **TADVANCEDEDITFORM** – Used when editing a naming field in the font. The default push button is **OK**.
* **TADVANCEDNAMINGFORM** – For versions 3.0 through 6.0 only, used when including additional naming fields for a font. The default push button is **OK**. See `TFONTPROPERTIESFORM` in recent versions.
* **TAUTOKERNINGFORM** – Used when automatically adding kerning pairs to the legacy kerning tables. The default push button is **Next**.
* **TAUTOMETRICSFORM** – Used when automatically generating metrics for glyphs. The default push button is **Next**.
* **TAUTONAMEFORM** – Used when automatically changing the naming fields of a font. The default push button is **Next**.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** – The default push button is **OK**.
* **TCODEPAGERANGEFORM** – Displays a dialog where you can enable or disable which encoding to support in the font. The default push button is **OK**.
* **TCOLORFORM** – It's not the standard Windows color selection dialog.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Used when modifying the properties of each composite glyph member. The default push button is **OK**.
* **TCONVERTBITMAPTOCONTOURSFORM** – Used when converting bitmaps to contours into contours. The default push button is **OK**.
* **TDISABLEDFORM** – For version 6.0 and 8.0 until 12.0.0.2539 only, displays this form used by reduced functionality mode or when pressing **Use Evaluation Version** in the splash screen after the 30-day grace period.
* **TDM** – This data is binary.
* **TEXPORTGLYPHDATAFORM** – Used when exporting glyph data. The default push button is **OK**.
* **TEXTRACTFROMTTCFORM** – Used by **Tools: Extract from TTC...** to extract TrueType font collections. The default push button is **Next**.
* **TFINDFORM** – Used when searching parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** – Used when changing embedding and licensing rights in the font. The default push button is **OK**.
* **TFONTHEADERFLAGSFORM** – Used when changing header flags in the font. The default push button is **OK**.
* **TFONTINSTALLWIZARDFORM** – Used when installing the font for use with other applications. The default push button is **Next** or **Finish**.
* **TFONTOVERVIEWFORM** – Shows the glyphs available in any opened font.
* **TFONTPROPERTIESFORM** – Used when viewing the font properties. The default push button is **OK**.
* **TFONTSETTINGSFORM** – Displays a dialog where you can change various settings for the font. The default push button is **OK**.
* **TFONTTABLESFORM** – Displays a dialog where it shows a full list of tables in the font. The default push button is **OK**.
* **TFONTTESTFORM** – Used when testing TrueType or OpenType fonts (not web fonts). Version 3.0 has a dropdown list to choose the encoding, which this is implemented with Windows 95. The Sample Text list in versions 5.0 through 6.0 is predefined and cannot be edited. Version 3.0 through 6.0 only prints ASCII characters in the current font.
* **TGASPFORM** – Used when managing gasps in the font. The default push button is **OK**.
* **TGENERATECONTOURSCANCELFORM** – The default push button is **Cancel**.
* **TGENERATEPROBLEMREPORTFORM** – Used when pressing **Next** in the Glyph Validation Wizard. The problem report is "Report". The default push button is **OK**.
* **TGLYPHALREADYMAPPEDFORM** – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do. The default push button is **Yes**.
* **TGLYPHEDITFORM** – Used when opening any glyph from the overview.
* **TGLYPHPROPERTIESFORM** – For old versions of FontCreator, displays a dialog where you can change various properties for the selected glyph. The **Help** button does nothing in old versions.
* **TGRIDFORM** – Used when changing grid settings. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TGUIDELINEMODIFYFORM** – Used when modifying guidelines. The default push button is **OK**.
* **TGUIDELINESFORM** – Used when changing guideline settings. The default push button is **OK**. The **Help** button does nothing in old versions.
* **THLCREGISTERABOUTBOXDLG** – Non-standard About box for old versions only.
* **TIMPORTGLYPHDATAFORM** – Used when importing glyph data. The default push button is **OK**.
* **TINSERTGLYPHFORM** – Used when inserting glyphs. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TINSTALLEDFONTSFORM** – Displays a dialog to open installed fonts in the computer. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TKERNINGFORM** – Used in old versions when viewing or editing the legacy kerning tables (not the GPOS kerning tables). See the OpenType Designer in recent versions to edit the GPOS kerning tables.
* **TKERNINGNEWPAIRFORM** – Used when adding a kerning pair to the legacy kerning tables. The default push button is **OK**.
* **TMAINFORMFCP3** – Version 3.0 only. Used when starting FontCreator. (See `TMAINFORMFONTCREATOR` in recent versions)
* **TMAINFORMFONTCREATOR** – Used when starting FontCreator.
* **TMETRICSFORM** – Used when configuring metrics options. The default push button is **OK**.
* **TNAMINGFORM** – For versions 3.0 through 6.0 only, displays a dialog where you can manually change the naming fields of a font. The default push button is **OK**. See `TFONTPROPERTIESFORM` in recent versions.
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font. The default push button is **OK**.
* **TOPTIONSFORM** – Displays a dialog where you can set a plethora of FontCreator options. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TPASTESPECIALFORM** – Used when pasting data for glyphs in the clipboard. The default push button is **OK**. In the Items list (versions 5.5 through 6.0 only), Glyph Outline Data and Glyph Metrics (i.e. the first two items) are checked by default.
* **TPCLTFORM** – For versions 3.0 through 6.5 only, displays a dialog where you can include or edit the old PCL5 data for legacy printers. The default push button is **OK**.
* **TPERFORMTRANSFORMATIONFORM** – For versions 5.6 and newer, displays the Glyph Transformer. The default push button is **OK**.
* **TPLATFORMMANAGERFORM** – For versions 2.0 through 6.5 only, displays a dialog where you can choose which platform to support in the font. The default push button is **OK**.
* **TPOSTSCRIPTNAMESFORM** – Used when changing PostScript names for any glyph in the font. The default push button is **OK**.
* **TPRINTABORTFORM** – Used when cancelling font printing process.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing a glyph.
* **TPROGRESSFORM** – Progress window. The cursor for this form is **Busy**. The default push button is **Cancel**.
* **TREGISTERFORM** – For unregistered copies of FontCreator, displays a dialog where you can enter the registration code (**Help: Register**). This removes the splash screen on startup and enables most features disabled in versions 6.0 and 8.0 until 12.0.2539 for unregistered users.
* **TRESOURCEEDITORDLG** – In old versions only, used when editing resources.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Used when adding glyph members to a composite glyph. The default push button is **OK**.
* **TSHAREWAREFORM** – For unregistered copies of FontCreator, displays this notice when pressing **Start** on the splash screen after the trial period is exceeded. (Only in old versions)
* **TSORTGLYPHSFORM** – Used when changing the glyph order within a font. The default push button is **OK**.
* **TSPLASHFORM** – Displays this form when starting in unregistered mode. The three buttons at the bottom are displayed in random order. After the trial period is exceeded and running the program five times, it displays a random paragraph.
* **TTIPOFTHEDAYFORM** – Used in version 1.0 until 6.0 and also for newcomers and also in **Help: Tip of the Day**. FontCreator.tip will be used to display tips. On unregistered copies is a button labeled **Register**. If removed when not registered, it displays the "Access Violation". See FontCreator: Tips and Tricks in the High-Logic font forum for more details.
* **TTRANSFORMFORM** – For simple glyphs only. The default push button is **Apply**.
* **TUNICODERANGEFORM** – Used when specifying the Unicode blocks or ranges encompassed by the font file in the mappings for double-byte platforms. The default push button is **OK**.
* **TUPDATEREMINDERFORM** – Used when the program checks for updates as if **OnStartupShowUpdateReminder** is enabled. The default push button is **OK**.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph. The default push button is **OK**.
* **TVALIDATIONWIZARDFORM** – Displays a dialog where you can validate the font for errors. The default push button is **Next**.
* **TWARNINGFORM** – Used for warnings. (See also `TWIDEWARNINGFORM` in new versions)
* **TWELCOMEFORM** – Used for newcomers as if **OnStartupShowWelcome** is enabled. The default push button is **OK**.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** – Used for warnings, replaces `TWARNINGFORM` in old versions.
