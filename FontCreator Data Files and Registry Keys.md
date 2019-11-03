## Notes
* The cursor will remain "Busy" when saving fonts while you do other stuff in the background.
* All versions allows you to save all unaltered opened fonts from the menu (**File: Save All**) but not in the Standard toolbar. In double-byte versions of Windows, the system may display a critical error saying "List index out of bounds (0)". Single-byte versions of Windows does nothing.
* If you exit the program, it may create invalid font(s) and play the Critical Stop sound from the PC speakers.
* The program displays the "Access violation" when closing after doing some operations – the font(s) may be invalid.
* Any glyph stored in the clipboard will have either "Glyph Contours" or "Glyph Data".
* The menu item **Edit: Delete** is not dimmed on startup or when closing other dialogs.
* Complete Composites (when generated from `CompositeData.xml` but not auto or anchor based) slows down the first time using in simple and composite glyphs.
* Version 5.0 until 6.0 makes **Complete Composites** dimmed in empty glyphs.
* Version 1.0 until 7.0 does not support unmapped glyph(s) or glyph(s) with Unicode SMP mapping(s) in the preview toolbar.
* The postscript name generation and additions to preview toolbar in versions 5.0 through 6.5 only supports glyphs with a Windows Unicode BMP mapping.
* The program displays a critical error if you use Complete Composites in some glyphs in the Private Use Area. After that, these glyphs cannot be recovered. [Bhikkhu Pesala](http://www.softerviews.org/Fonts.html), UK has assigned code points in the Private Use Area for different glyphs in his fonts, notably low profile diacritics and small capitals. Rebecca G. Bettencourt / [Kreative Korp](http://www.kreativekorp.com/) has assigned code points in the Private Use Area for different glyphs in her fonts, notably extended block elements.
* If you want to change resources in versions containing a non-standard resource layout (tested with version 5.6), you would have to use [Resource Tuner](http://www.heaventools.com/resource-tuner.htm) (tested with version 2.20) or [UPX](https://upx.github.io/) (tested with version 2.01 for DOS running on Windows XP Professional K SP3 - this version was released in 2006 and distributed with FreeDOS) to unpack the executable file which isn't possible as UPX says it's not packed.
* In new fonts, the Euro (€) doesn't have a Macintosh Roman mapping but the international currency sign (¤) does have it.
* The euro (€) and international currency sign (¤) use the same mapping in the Macintosh Roman glyph mapping list.
* Version 1.0 until 5.6 use ISO Latin-1 as the output encoding. East Asian users (e.g. Korean) will appreciate in `previewtext.dat` substitutes accented letters by ASCII counterparts, e.g. é by e and if kerning pairs are exported, instead of having &lt;&lt; for « you have to use \\00AB as escape code.

## Unregistered version limitations
As FontCreator is released as pay shareware, the unregistered version works for 30 days with the following limitations based on the version number.
* 3.0β1 (2000-07-30) until 3.1.3 (2002-12-09) - After a grace period of 30 days, a nag screen is shown when pressing **Start**. However, the program otherwise functions normally.
* 4.0 (2003-05-16) until 4.5 (2004-08-17) - After a grace period of 30 days, the program cannot be used at all until the registration process is started.
* 5.0 (2005-01-12) until 5.6 (2007-07-19) - After a grace period of 30 days and opening the program 5 times, the program will enter a reduced functionality mode, where e.g. fonts cannot be saved or tested.
* 6.0 (2009-06-17) and 8.0 (2014-06-05) until 12.0.0.2539 (2019-06-04) - The program will enter a reduced functionality mode, where e.g. tested fonts won't be automatically hinted.
* 7.0 (2013-04-25) - The program will create subsetted versions when saving, testing, exporting or installing fonts.
* 12.0.0.2543 (2019-07-10) - The program will add watermarks when generating fonts.

Under the Help menu is an item labeled **Register** when this executed a screen will pop up giving the registration code.

## Windows version compatibility
* Windows Vista and later – 12.0.0.2543
* Windows XP – 10.0
* Windows 2000 – 7.0
* Windows NT 4.0 – (unknown version)
* Windows 95, 98 and ME – 6.0.1

## User Data (Glyph Transformer scripts and Unicode data files omitted)
FontCreator uses several data files for advanced settings and customizations. Normally most files are owned by administrators where they cannot be changed. If you want to edit most files directly they either must run Notepad with administrative privileges or change the owner to users (this can be done by using `takeown` or changing the owner with the advanced dialog of security tab in file properties).

* **bookmarks.txt** (version 5.0 until 6.5) – Created automatically after exit. Includes bookmarks used in the glyph overview.
* **CompositeData.xml** – Located in the `Composite` folder as used by **Complete Composites**.
* **CurrentTransformProgram.xml** – Created when opening Transform Programs in `TPERFORMTRANSFORMATIONFORM`. The window will appear empty if removed.
* **FC#####.ttf** – Temporary font used by `TFONTTESTFORM` (##### is five numbers). The font name in version 3.0 until 6.5 is FC Test Font ###### (###### is six numbers).
* **fc12.cfg** – Configuration file used by FontCreator.
* **fcp5.cfg** – Configuration file used by FontCreator 5.0 and 5.6 in the system root directory.
* **fcppreview.txt** (version 3.0 until 4.5) – Controls the text used in `TFONTTESTFORM`. The text is restored to factory defaults if removed.
* **fnt[XX/XXX].tmp** – Temporary font used for saving (XX or XXX are letter and number combos).
* **FontCreatorSetup.exe** – Install the program for use with x86 platform (32 bit).
* **FontCreatorSetup-x64.exe** – Install the program for use with x64 platform (64 bit).
* **FontCreator.tip** – Contains the tips in `TTIPOFTHEDAYFORM`. If removed, this window appears blank.
>>>>>>> 2cc2495 (Updated FontCreator application data)
* **glyphlist.dat** – Contains the Adobe glyph list. Old versions have the same list but duplicates **xi** to U+0000.
* **glyphnamesnew.dat** – For version 7.0 and above, contains the default glyph names when opening existing fonts and when you generate glyph names on the Glyph Properties dialog. Prior to FontCreator 12 another file (`glyphnames.dat`) was used, but that one is now obsolete.
* **guidelines.dat** – Created automatically after exit. Includes guidelines used in Glyph Edit window and Guideline Options.
* **kern_filename.txt** – For old versions of FontCreator, stores the legacy kerning pair data for each font whereas filename is the name of each font.
* **previewtext.dat** – For version 3.0 until 6.0, controls the text used in Test Font Window. Text in `TFONTTESTFORM` is restored to factory defaults if removed.
* **preview.txt** – Contains the standard preview texts for the Preview toolbar. The dropdown list appears blank if removed.
* **SubFamily.dat** or **SubFamily2.dat** – Includes naming fields for different languages.
* **TableOffsetOrder.dat** – Contains the tables supported by any font. All tables are moved to Unsupported if removed. Newer versions changed the file extension to txt and added another file named TableOffsetOrderCFF.
* **tags.txt** – For version 7.0 and above, controls the names of the five tags that can be assigned to each glyph.

In **Options: Advanced: Data Files** are two buttons labeled **Copy Data Files to User Data Folder** and **Open User Data Folder** when pressed the program will either copy most files to the user data folder or open it.

## Registry Keys

### AddCharacters
* **SelectedCharacter** – Character used in the **Insert Characters** dialog. Default is beginning of Basic Latin Unicode block.
* **SelectedFont** – Font used in the **Insert Characters** dialog. Default is **Arial Unicode MS**.

### Background
* **BackgroundInitColor**
* **BackgroundInitScale**

### Columns
* **Open Installed Fonts** – This is a binary value.

### Externals
There are three built-in external programs: Fonts Folder, Character Map and MainType (if installed).
* **Location#** – The name can be up to digit three. Default is empty.
* **Title#** – The name can be up to digit three. Default is **External #** whereas # is a number.

### Find
* **FindLanguageID** – This corresponds to any language.
* **PlatformID** – See **Platform** in the Find dialog's Mapping tab.
* **PlatformSpecificEncodingID** – See **Platform** in the Find dialog's Mapping tab.
* **TabIndex** – This corresponds to any tab in the Find dialog.

<<<<<<< HEAD
### FontOverview
* **CategoryWidth**
=======
### FontOverview (used in `TFONTOVERVIEWFORM`)
* **CategoryWidth** – Select the width used for categories in the font overview.
>>>>>>> 9c7dc26 (Updated Ubuntero list and FontCreator application data)

### Fonts
* **ExportDecomposeScaled** – Used with **Export Font: Decompose composite glyphs with scaled components** checkbox in Options: Font. Default is on.
* **ExportExcludeLegacy** – Used with **Export Font: Exclude legacy data** checkbox in Options: Font. Default is on.
* **FontEnableOpenContours** – Used with **Special Features: Enable open contours** checkbox in Options: Font. Default is on.
* **OpenFriendlyGlyphNames** – Used with **Open Font: Generate friendly glyph names** checkbox in Options: Font. Default is on.

### FreeDraw
* **BrushWidth** – Used with **Brush width** option in the Free Draw window.

### Glyph Edit Window
* **FilledOutline** – Used with **Fill Outline** in the Grid toolbar.
* **ShowConnectionBetweenPoints** – Used with **Show Connection** in the Grid toolbar. Default is on.
* **ShowFirstAndLastPointIndicators** – Used with **Show First and Last** in the Grid toolbar. Default is on.
* **ShowToolbarWindowBackground** – Enables or disables the Background Image toolbar. Default is off.
* **ShowToolbarWindowKerning** – Enables or disables the kerning window. Default is off.
* **ShowToolbarWindowPalette** – Used with **Palette** in the toolbar right click context menu.
* **ShowToolbarWindowTransformation** – Used with **Transformation** in the toolbar right click context menu.
* **ShowToolbarWindowValidation** – Used with **Show Report** in the Glyph toolbar. Default is off.

### Grid
* **FixedGridColor** – Used with **Color** in Grid Options. Default is pink.
* **FixedGridLineStyle** – Used with **Line style** in Grid Options. Default is solid.
* **GridColor** – Used with **Color** in Grid Options. Default is pink.
* **GridDistance** – Used with **Mininum distance between grid points in units** in Grid Options.
* **GridDistancePixels** – Used with **Mininum distance between grid points in pixels** in Grid Options.
* **GridLineStyle** – Used with **Line style** in Grid Options. Default is solid.
* **IncludeBaseline** – Used with **Baseline** in the Metrics Options window.
* **IncludeLeftSideBearing** – Used with **Left side bearing** in the Metrics Options window. Default is on.
* **IncludeRightSideBearing** – Used with **Right side bearing** in the Metrics Options window. Default is on.
* **IncludeTypoAscender** – Used with **TypoAscender** in the Metrics Options window.
* **IncludeTypoDescender** – Used with **TypoDescender** in the Metrics Options window.
* **IncludeWinAscent** – Used with **Win Ascent** in the Metrics Options window.
* **IncludeWinDescent** – Used with **Win Descent** in the Metrics Options window.
* **IncludexHeight** – Used with **x-Height** in the Metrics Options window.
* **IncludeYAxis** – Used with **Y-Axis** in the Metrics Options window.
* **LockUserDefinedGuidelines** (version 4.5 & above) – Used when pressing **Lock Guidelines** in the Grid toolbar.
* **ShowBearings** (version 5.6 & above) – Used when pressing **Show Metrics** in the Grid toolbar.
* **ShowFixedGridLines** (version 5.6 & above) – Used with **Show reference lines at x = 0, y = 0** option in Grid Options.
* **ShowGrid** – Used when pressing **Show Grid** in Grid Options or in the Grid toolbar.
* **ShowUserDefinedGuidelines** – Used when pressing **Show Guidelines** in Guidelines Options or in the Grid toolbar. If Microsoft Narrator is running, the checkbox in the Guidelines Options window will read the ampersand.
* **SnapToGrid** (version 4.5 & above) – Used when pressing **Snap to Grid** in the Grid toolbar.
* **SnapToUserDefinedGuidelines** (version 4.0 & above) – Used when pressing **Snap to Guidelines** in the Grid toolbar.

### GUI
* **UpdateCheckInterval** – Used when **OnStartupShowUpdateReminder** is enabled.

### GuideLines
* **Color** – Used with **Color** option in Guideline Options. Default is black.
* **LineStyle** – Used with **Line style** options in Guideline Options. Default is solid.

### ImportImage
* **BitmapPositionOrigin** – Used with radio buttons in the Glyph: Position option. (Available in Import Image)
* **BitmapPositionType** – Set the Bitmap Position Type.
* **Erode** – Used with **Erode – Dilate** option in the Image tab. Default is No filter. (Available in Import Image)
* **GlyphPositionX** – Used with **Position: X position** option in the Glyph tab. (Available in Import Image)
* **GlyphPositionY** – Used with **Position: Y position** option in the Glyph tab. (Available in Import Image)
* **ImportMode** – Used with **Import Mode** option in the Glyph tab. Default is Trace. (Available in Import Image)
* **InvertBitmap** – Used with **Negative** option in the Image tab. Default is off. (Available in Import Image)
* **MinimumPointsInContour** – Set the number of Minimum Points in the contour.
* **Multiplier** – Used with **Size: Multiplier** option in the Image tab. (Available in Import Image)
* **SmoothFilter** – Used with **Smooth Filter** option in the Image tab. Default is Smooth. (Available in Import Image)
* **Threshold** – Used with **Threshold** option in the Image tab. Default is 150. (Available in Import Image)

<<<<<<< HEAD
### Install
* **InstallFontsInFontsFolder** – Used with **Install the font in Windows Fonts folder** option in the Font Installation Wizard. Default is on. On Windows Vista and above, this option requires administrator privileges.
=======
### Install (used in `TFONTINSTALLWIZARDFORM`)
* **InstallFontsInFontsFolder** (version 3.0 until 6.5) – Used with **Install the font in Windows Fonts folder**. Default is on. If the program is ran under Windows Vista & above, the UAC shield is added before the label.
>>>>>>> 9c7dc26 (Updated Ubuntero list and FontCreator application data)

### InstalledFonts
* **PreviewHeight** – Select the height used for the preview area in the Open Installed Fonts window.

### Interface
* **LockToolbars** – Used with **Lock Docked Toolbars** option in the toolbar context menu or in View: Toolbars. Default is off.
* **ShowUserNotes** – Used with **Show User Notes** option in the toolbar context menu or in View: Toolbars. Default is off.

### Interface Settings
* **ChildWindowState**
* **CompleteCompositesAction** – Used with **Complete Composites** button in the toolbar. Default is **Auto**.
* **CustomNamingShowOutputContent**
* **GlyphCaptionAuto** – Used with **Captions: Automatic** in the right-click context menu of font overview.
* **GlyphCaptionType2** – Used with the Captions options in the right-click context menu of font overview.
* **GlyphDrawMode**
* **GlyphFillAlpha** – Used with **Fill Outline** in the View menu.
* **GlyphNamesHistoryReplace** – Contains the postscript names to replace in history.
* **GlyphNamesHistorySearch** – Contains the postscript names to find in history.
* **GlyphNamesOptionsCS**
* **GlyphNamesOptionsRE**
* **GlyphOutlineFillMode** – Used with **Glyph outline fill mode** in the Options: General tab.
* **GlyphPropsExpanded** – Used to expand the glyph properties.
* **GroupManagerSorted** – Used to sort the group manager.
* **InsertGlyphsCB1** and **InsertGlyphsCB2** – Select this value in the insert glyphs window to either insert each glyph at top (0), after last glyph (1), before each selected glyph (2) or after each selected glyph (3). Default is 3 (after each selected glyph).
* **InsertGlyphsPage** – Select the page used in the Insert Glyphs dialog.
* **KerningFolderExport** – Directory used to export the legacy kerning tables.
* **KerningFolderImport** – Directory used to import the legacy kerning tables.
* **NewFontIncludeOutlines** – Used with **Predefined outlines: Include outlines** in the new font dialog. Default is on.
* **OpenDialogInitialDir2** – Directory used in Open dialog.
* **OpenDialogInitialDirAutoKerning** – Directory used in AutoKern Open dialog.
* **OpenDialogInitialDirImportImage** – Directory used in Import Image Open dialog.
* **OpenDialogInitialDirNamingField** – Directory used in Edit Naming Field Open dialog.
* **OpenDialogInitialDirTransform** – Directory used in Glyph Transformer Open dialog.
* **OptionsPage** – Select the tab used in the Options dialog.
* **OTLFDesignerCollapsedFeatures**
* **OTLFDesignerCollapsedLookups**
* **OTLFDesignerCollapsedScripts**
* **OTLFDesignerPreviewLanguage** – Select the language used for the preview text in the OpenType layout designer.
* **OTLFDesignerPreviewSampleText** – Select the sample text used for the preview text in the OpenType layout designer.
* **OTLFDesignerPreviewScript** – Select the script used for the preview text in the OpenType layout designer.
* **OTLFEditor**
* **OverviewColCat**
* **OverviewFontZoom**
* **OverviewGridZoom**
* **OverviewSampleFont** (version 4.0 & above) – Used with **Font Overview: Font used in cells** option in the View tab. Default is **Arial**. Empty strings will display all glyphs using **MS Sans Serif** with the glyphs shifted to other position. (Available in the Options window)
* **OverviewShowCaption** – Used with **Font overview: Show caption** option in the Overview tab. Default is on. (Available in the Options window)
* **OverviewShowSample** – Used with **Font Overview: Show sample in empty glyphs** option in the Overview tab. Default is on. (Available in the Options window)
* **OverviewSingleHeight** – Used with **Font overview: Glyph height** option in the Overview tab. Default is 48. (Available in the Options window)
* **OverviewSingleWidth** – Used with **Font overview: Glyph width** option in the Overview tab. Default is 70. (Available in the Options window)
* **OverviewSmoothGlyphs** – Used with **Font overview: Smooth glyphs** option in the Overview tab. (Available in the Options window)
* **OverviewUndoLimitMaxCount** – Used with **Undo limits: Max. count** option in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUndoLimitMaxSize** – Used with **Undo limits: Max. size [KB]** option in the Edit tab. Default is 1. (Available in the Options window)
* **OverviewUseColor** – Used with **Font overview: Use type color in glyph caption** option in the Font tab. If enabled, glyph captions are shown in different colors. If disabled, glyph captions are shown in black. (Available in the Options window)
* **SampleFileName** – Used with **Samples Toolbar Font: Filename** option in the General tab. Default is blank.
* **SampleSingleHeight** – Used with **Samples Toolbar: Glyph height** option in the Sample tab. Default is 55. (Available in the Options window)
* **SampleSingleWidth** – Used with **Samples Toolbar: Glyph width** option in the Sample tab. Default is 62. (Available in the Options window)
* **SelectCompositeCaptionType**
* **SelectCompositeFontZoom**
* **SelectCompositeGridZoom**
* **SettingsPage** – Select the tab used in the Settings dialog.

### Kerning
* **AutoKerningAllowForPositiveKerningValues** – Used with **Additional Options: Allow for positive kerning values** option in the AutoKern window.
* **AutoKerningExcludeLowerLower** – Used with **Exclude lowercase-lowercase pairs** option in the AutoKern window.
* **AutoKerningExcludeLowerUpper** – Used with **Exclude lowercase-uppercase pairs** option in the AutoKern window.
* **AutoKerningUseBaseMetrics** – Used with **Composite glyphs follow base glyphs (use this glyph's metrics)** option in the Kern Wizard in OpenType Designer. Default is on.
* **AutoKerningImportFilename** – Used with disabled text box with the filename string.
* **AutoKerningMinAbsKernValue** – This corresponds to numerical strings for the **Additional Options: Minimum absolute kerning value** option in the AutoKern window.
* **AutoKerningReplaceKerning** – Used with **Additional Options: Replace existing kerning when** dropdown box in the AutoKern window.
* **AutoKerningReplacePercentage** – Used with **Additional Options: Replace existing kerning when** slider in the AutoKern window.
* **AutoKerningWhiteSpace** – Used with **Additional Options: White space between characters** option in the AutoKern window.
* **KerningColorBackground** – Select the color used for the background. Default is white.
* **KerningColorBaseline** – Select the color used for the baseline. Default is red.
* **KerningColorFirst** – Select the color used for the left glyph. Default is dark blue.
* **KerningColorGridLines** – Select the color used for the Grid Lines. Default is gray.
* **KerningColorSecond** – Select the color used for the right glyph. Default is dark green.
* **KerningShowBaseLine** – Display baseline in Kerning window. Default is on.
* **KerningShowBearingLines** – Display bearing lines in Kerning window. Default is on.
* **KerningShowGridLines** – Display grid lines in Kerning window. Default is on.

### Last Time
* **File_#** – Include fonts used in the last time whereas # is a number. When `OnStartupOpenFonts` is enabled, nothing will be opened if removed.

### Metrics
* **AutoMetricsExcludeEmptyGlyphs** – Used with **Additional Options: Exclude empty glyphs (recommended)** option in the Automatic Metrics Wizard.
* **AutoMetricsFixedAW** – Used with **Fixed: Change Advance Width** spinner in the Automatic Metrics Wizard.
* **AutoMetricsFixedChangeAW** – Used with **Fixed: Change Advance Width** option in the Automatic Metrics Wizard.
* **AutoMetricsFixedChangeLSB** – Used with **Fixed: Change Left Side Bearing** option in the Automatic Metrics Wizard.
* **AutoMetricsFixedLSB** – Used with **Fixed: Change Left Side Bearing** spinner in the Automatic Metrics Wizard.
* **AutoMetricsOpticalFactor** – Used with **Glyph spacing factor** in the Automatic Metrics Wizard. Default is 27.
* **AutoMetricsOpticalPreview** – Used with **Preview Text** in the Automatic Metrics Wizard. Default is Preview Text.
* **AutoMetricsOptionIndex** – Used with radio buttons in the Automatic Metrics Wizard.
* **AutoMetricsWhiteSpaceAfter** – Used with **Calculated: White space after characters** option in the Automatic Metrics Wizard.
* **AutoMetricsWhiteSpaceBefore** – Used with **Calculated: White space before characters** option in the Automatic Metrics Wizard.

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
* **MarkWidth**
* **PairWidth**
* **PreviewHeight** – Used with preview text height in the OpenType Designer.
* **PreviewSampleFontSize** – Used with preview sample font size in the OpenType Designer.
* **SimpleWidth**
* **SingleWidth**
* **TreeWidth**
* **ZoomFactor**

### Options
* **AlwaysCreateBackupCopy** – Used with **Create backup copy (bck) on saving a font project** in the Advanced: Settings tab. If disabled, no backup copy is created on saving. Default is off.
* **AutoFitGlyphInWindow** – Used with **Glyph Edit Window: Auto fit glyph in Window** in Options: Glyph. Default is on.
* **AutoNamingUseFontRevision** – Used with **Automatic Naming Wizard: Version String: use Font revision version from Font Settings → Header page** in Options: Naming. Default is on.
* **CompressHmtxTable** – Used with **When Saving Font Files: Compress hmtx table** in the Font tab. (Available in the Options window)
* **CompressNameTable** – Used with **When Saving Font Files: Optimize name table** in the Font tab. (Available in the Options window)
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
* **ExcludeMonospacedFonts** – Used with **When Saving Font Files: Exclude monospaced fonts** in the Font tab. Enabling it will omit all monospace fonts on saving. Disabling it will include monospaced fonts during saving. (Available in the Options window)
* **IgnoreHintingData** – Used with **When Opening Font Files: Remove hinting data** in the Font tab. Enabling it will remove hinting data. Disabling it will keep hinting data. (Available in the Options window)
* **IgnoreUnsupportedTables** – Used with **When Opening Font Files: Remove unsupported tables** in the Font tab. Enabling it will remove unsupported tables. Disabling it will keep unsupported tables. (Available in the Options window)
* **LastUpdateReminderDate** – Used when **OnStartupShowUpdateReminder** is enabled.
* **LeftSideBearingExcludeLargeFonts** – Used with **When Saving Font Files: Set left side bearing point at x=0: Exclude large (1500+) fonts** in the Font tab. If enabled, it will omit all fonts with a large number of glyphs on saving. (Available in the Options window)
* **LongAlignedLocalOffsets** – Used with **When Saving Font Files: Long-aligned local offsets** in the Font tab. (Available in the Options window)
* **OnStartupOpenFonts** (version 5.6 & above) – Used with **Startup: On start open fonts from last time** in the General tab. Default is on. (Available in the Options window)
* **OnStartupShowUpdateReminder** – Used with **Startup: Show update reminder** in the General tab. Default is Once a year. (Available in the Options window)
* **OnStartupShowWelcome** – Used with **Startup: On start show Welcome dialog** in the General tab. Default is on. (Available in the Options window)
* **PanoseValueHexadecimal** – Used with **PANOSE: Value: Show hexadecimal** in Font Properties: Characteristics. If enabled, the PANOSE value is displayed in hexadecimal. If disabled, the PANOSE value is displayed in decimal.
* **RecalcAverageCharWidth** – Used with **When Saving Font Files: Recalc average char width** in the Font tab. (Available in the Options window)
* **RecalcGlyphBoundingBoxes** – Used with **When Saving Font Files: Recalc glyph bounding boxes** in the Font tab. (Available in the Options window)
* **RemoveDSIGTable** – Used with **When Opening Font Files: Remove DSIG table** in the Font tab. Enabling it removes this table. Disabling it keeps this table. (Available in version 5.5 through 6.5 only)
* **RemoveHdmxTable** – Used with **When Opening Font Files: Remove hdmx table** in the Font tab. Enabling it removes this table. Disabling it keeps this table. (Available in version 5.5 through 6.5 only)
* **RemoveLTSHTable** – Used with **When Opening Font Files: Remove LTSH table** in the Font tab. Enabling it removes this table. Disabling it keeps this table. (Available in version 5.5 through 6.5 only)
* **RemoveVDMXTable** – Used with **When Opening Font Files: Remove VDMX table** in the Font tab. Enabling it removes this table. Disabling it keeps this table. (Available in version 5.5 through 6.5 only)
* **SetLeftSideBearingPointAtX0** (version 4.5 & above) – Used with **When Saving Font Files: Set left side bearing point at x=0** in the Font tab. Default is on. (Available in the Options window)
* **UnicodeEnabledGUI** (version 5.5 until 6.1) – Used with **Unicode Support: Enable Unicode support for text display and user input** in the General tab. Default is on. Disabling it will use the codepage based on the **Language For Non-Unicode Programs** variable. If the program is ran under Windows 9x/ME or compatibility mode, the option will appear dimmed.
* **UpdateModifiedDateTimeField** – Used with **Identification: Automatically update modified timestamp when exporting font** in the Font Properties: Identification tab. Default is on.
* **ValueHexadecimal** – Used with **Values: Hexadecimal** in the View: Display Format menu. Default is on. Hexadecimal values in Delphi are usually given with a dollar sign ($).
* **VectorImageEPSForceRepositioning** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Move imported outlines to origin (0,0)** in Options: Import. Default is off.
* **VectorImageEPSOriginX** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin X** in Options: Import. Default is 100.00.
* **VectorImageEPSOriginY** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Origin Y** in Options: Import. Default is 600.00.
* **VectorImageEPSPixelsPerEm** – Used with **Vector Based Images (EPS, AI, PDF, SVG): Pixels per em** in Options: Import. Default is 512.00.

### Preview
* **FeaturesWidth** – Contains the width used for OpenType features.
* **FeatureTags** – Contains the tags used for OpenType features.
* **PreviewFeatures** – Enable or disable any OpenType feature for the preview text.
* **PreviewFontSize** – Select the size in the Test Font window. Default is 24.
* **PreviewSampleFontSize** – Select the size in the Preview window.
* **PreviewSampleText** – Used with the dropdown box in the Preview window. Default is **High-Logic ©** (old versions) or **&lt;enter preview text here&gt;**.
* **PreviewSampleUseKerning** – Set this value to on to kern text in the Preview window.
>>>>>>> 9c7dc26 (Updated Ubuntero list and FontCreator application data)
* **ShowToolbarWindowPreview** – Show or hide the Preview window. Default is on.
* **StrikeThrough** – Used for **Strikeout** in the Test Font window. Default is off.
* **Underline** – Used for **Underline** in the Test Font window. Default is off.

### Reg
The program is started in unregistered mode either after the installation process is finished or if all keys are empty. Many people provided registration keys for different versions.
* **V5D#** – Created after registration whereas # is a numerical string. It displays a message and removes the **Buy** menu and the **Register** item on the Help menu. Version 6.0 & above places your name on the title bar.
>>>>>>> 9c7dc26 (Updated Ubuntero list and FontCreator application data)

### Themes
* **ActiveTheme**

### Tip of the Day (version 3.0 until 6.5, used in `TTIPOFTHEDAYFORM`)
* **CurrentTip** – Current line number in `FontCreator.tip`, used after opening.
* **ShowTipOnStartup** – Used when selecting **Show this screen next time when you start FontCreator**. Default is on.

### Validation
* **DiagonalRedundantOffCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum off-curve distance** in Settings: Validation.
* **DiagonalRedundantOnCurvePointsDetection** – Used with **Diagonal redundant points detection: Maximum on-curve distance** in Settings: Validation.
* **EnableGlyphProblemDetection** – Used with **Enable Real-Time** in the Validation toolbar.
* **LocalExtremeCoordinatesDetection** – Used with **Off-curve extreme coordinates: Local detection** in Settings: Validation. Default is on.
* **MaximumRedundantOffCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum off-curve distance** spinner in Settings: Validation. Default is 0.20.
* **MaximumRedundantOnCurvePointsDistance** – Used with **Diagonal redundant points detection: Maximum on-curve distance** spinner in Settings: Validation. Default is 0.80.
* **ShowIntersection** – Used with **Show Intersecting** in the Validation toolbar. If enabled, intersecting contours are shown for each glyph. If disabled, no intersecting contours are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
* **ShowWarningPoints** – Used with **Show Warning Points** in the Validation toolbar. If enabled, warning points are shown for each glyph. If disabled, no warning points are shown for each glyph. If the glyph is too complex, the button will appear dimmed.
* **TestContoursWithIncorrectDirection** – Used with **Validation Tests: Contours with incorrect direction** in the Font Validation Wizard and **Correct Contour Directions** in the Validation toolbar. Default is on.
* **TestContoursWithOneOrTwoPoints** – Used with **Validation Tests: Contours with one or two points** in the Font Validation Wizard and **Remove Components** in the Validation toolbar. Default is on.
* **TestDuplicateComponents** – Used with **Validation Tests: Duplicate components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar. Default is on.
* **TestDuplicateContours** – Used with **Validation Tests: Duplicate contours** in the Font Validation Wizard and **Remove Duplicate Contours** in the Validation toolbar. Default is on.
* **TestDuplicateKnots** – Used with **Validation Tests: Duplicate knots** in the Font Validation Wizard and **Remove Duplicate Knots** in the Validation toolbar. Default is on.
* **TestEmptyComponents** – Used with **Validation Tests: Empty components** in the Font Validation Wizard and **Remove Components** in the Validation toolbar. Default is on.
* **TestFixDetectedProblems** – Used with **Fix detected problems** in the Font Validation Wizard. Default is off.
* **TestIntersectingComponents** – Used with **Validation Tests: Intersecting components** in the Font Validation Wizard. Default is on.
* **TestIntersectingCoordinates** – Used with **Validation Tests: Intersecting coordinates** in the Font Validation Wizard. Default is on.
* **TestOffCurveExtremeCoordinates** – Used with **Validation Tests: Off-curve extreme coordinates** in the Font Validation Wizard and **Add Off-Curve Extremes** in the Validation toolbar. Default is on.
* **TestOverlappingComponents** – Used with Validation Tests: Overlapping components** in the Font Validation Wizard. Default is on.
* **TestRedundantPoints** – Used with **Validation Tests: Redundant points** in the Font Validation Wizard and **Remove Redundant Points** in the Validation toolbar. Default is on.
* **TestSuspiciousPoints** (version 11.0.0.2365 & above) – Used with **Validation Tests: Suspicious points** in the Font Validation Wizard. Default is on.
* **ValidationMaxNumberOfCompositeGlyphMembers** – Used with **Real-time glyph validation: Disable when number of members exceeds** in Settings: Validation. Default is 1000.
* **ValidationMaxNumberOfContours** – Used with **Real-time glyph validation: Disable when number of contours exceeds** in Settings: Validation. Default is 100.
* **ValidationMaxNumberOfPoints** – Used with **Real-time glyph validation: Disable when number of points exceeds** in Settings: Validation. Default is 25.

### Warn (used in Options: Advanced – default is on for all options)
* **WarnBeforeActivatingFixFeature** (version 5.0 until 6.5) – Used with **Warn before activating the fix feature in the Font Validation Wizard**.
* **WarnBeforeActivatingRemoveFeature** (version 5.0 until 6.5) – Used with **Warn before activating a remove feature from the Options → Font page**.
* **WarnBeforeAddCharacters** (version 5.0 until 6.5) – Used with **Warn before adding characters**.
* **WarnBeforeAnchorDelete** – Used with **Warn when deleting anchor**.
* **WarnBeforeCloseOpenTypeDesigner** – Used with **Warn about losing changes when cancelling or closing OpenType Designer dialog**.
* **WarnBeforeExecutingGlyphTransformProgram** – Used with **Warn before executing Glyph Transformer script**.
* **WarnBeforeSortingGlyphs** (version 5.0 until 6.5) – Used with **Warn before sorting glyphs**.
* **WarnImportSmallImage** – Used with **Warn when importing small image**.
* **WarnWhenOpening10OrMoreFonts** – Used with **Warn when opening 10 or more fonts**.
* **WarnWhenProcessingVOLTTable** (version 9.0 & above) – Used with **Warn when opening a font file which contains a VOLT table**.

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
<<<<<<< HEAD
* **HLCSPINDOWN** – Used in the spinner control.
* **HLCSPINUP** – Used in the spinner control.
* **RZCMBOBX_DEVICE** – Used in the font dropdown list.
* **RZCMBOBX_FIXEDPITCH** – Used in the font dropdown list.
* **RZCMBOBX_PRINTER** – Used in the font dropdown list.
* **RZCMBOBX_TRUETYPE** – Used in the font dropdown list.
* **RZCMBOBX_TRUETYPEFIXED** – Used in the font dropdown list.
* **SPTBXGLYPHS** – Used by glyphs in the Glyph Overview. This resource uses Argentinian Spanish language.
=======
* **SPTBXGLYPHS** – Used by glyphs in the Glyph Overview.
* **SYNEDITINTERNALIMAGES** – Numbers in gray background
* **SYNEDITWORDWRAPPED** – Word wrap icon
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
* **TADVANCEDNAMINGFORM** – For versions 3.0 through 6.0 only, used when including additional naming fields for a font. The default push button is **OK**. See TFONTPROPERTIESFORM in recent versions.
* **TAUTOKERNINGFORM** – Used when automatically adding kerning pairs to the legacy kerning tables. The default push button is **Next**.
* **TAUTOMETRICSFORM** – Used when automatically generating metrics for glyphs. The default push button is **Next**.
* **TAUTONAMEFORM** – Used when automatically changing the naming fields of a font. The default push button is **Next**.
* **TCHARACTERTOGLYPHINDEXMAPPINGFORM** – The default push button is **OK**.
* **TCODEPAGERANGEFORM** – Displays a dialog where you can enable or disable which encoding to support in the font. The default push button is **OK**.
* **TCOLORFORM** – It's not the standard Windows color selection dialog.
* **TCOMPOSITEGLYPHPROPERTIESFORM** – Used when modifying the properties of each composite glyph member. The default push button is **OK**.
* **TCONVERTBITMAPTOCONTOURSFORM** – Used when converting bitmaps to contours into contours. The default push button is **OK**.
* **TDISABLEDFORM** – For version 6.0 and 8.0 until 12.0.0.2539 only, displays this form when trying to save/test/install fonts or extract TrueType font collections or when pressing Use Evaluation Version in the splash screen reminding that the trial period is exceeded.
* **TDM** – This data is binary.
* **TEXPORTGLYPHDATAFORM** – Used when exporting glyph data. The default push button is **OK**.
* **TEXTRACTFROMTTCFORM** – Used by **Tools: Extract from TTC...** to extract TrueType font collections. The default push button is **Next**.
* **TFINDFORM** – Used when searching parts of a font.
* **TFONTEMBEDDINGLICENSINGRIGHTSFORM** – Used when setting embedding and licensing rights in the font. The default push button is **OK**.
* **TFONTHEADERFLAGSFORM** – Used when setting the header flags in the font. The default push button is **OK**.
* **TFONTINSTALLWIZARDFORM** – Used when installing the font for use with other applications. The default push button is **Next** or **Finish**.
* **TFONTOVERVIEWFORM** – Shows the glyphs available in any opened font.
* **TFONTPROPERTIESFORM** – Used when viewing the font properties. The default push button is **OK**.
* **TFONTSETTINGSFORM** – Displays a dialog where you can change various settings for the font. The default push button is **OK**.
* **TFONTTABLESFORM** – Displays a dialog where it shows a full list of tables in the font. The default push button is **OK**.
* **TFONTTESTFORM** – Used when testing TrueType or OpenType fonts (not web fonts). Version 3.0 has a dropdown list to choose the encoding, which this is implemented with Windows 95. The Sample Text list in versions 5.0 through 6.0 is predefined and cannot be edited. Printing in version 3.0 through 6.0 only supports ASCII characters while others are printed with a system font.
* **TGASPFORM** – Used when managing gasps in the font. The default push button is **OK**.
* **TGENERATECONTOURSCANCELFORM** – The default push button is **Cancel**.
* **TGENERATEPROBLEMREPORTFORM** – Used when pressing **Next** in the Glyph Validation Wizard. The problem report is "Report". The default push button is **OK**.
* **TGLYPHALREADYMAPPEDFORM** – For each platform a character to glyph index mapping can only exist once, so if you try to add a mapping that already exists this window will ask you what to do. The default push button is **Yes**.
* **TGLYPHEDITFORM** – Used when opening any glyph from the overview.
* **TGLYPHPROPERTIESFORM** – For old versions of FontCreator, displays a dialog where you can change various properties for the selected glyph. Pressing Alt-Enter opens up this form without reading when a screen reader is running. The **Help** button does nothing in old versions.
* **TGRIDFORM** – Used when changing grid settings. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TGUIDELINEMODIFYFORM** – Used when modifying guidelines. The default push button is **OK**.
* **TGUIDELINESFORM** – Used when changing guideline settings. The default push button is **OK**. The **Help** button does nothing in old versions.
* **THLCREGISTERABOUTBOXDLG** – Non-standard About box for old versions only.
* **TIMPORTGLYPHDATAFORM** – Used when importing glyph data. The default push button is **OK**.
* **TINSERTGLYPHFORM** – Used when inserting glyphs. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TINSTALLEDFONTSFORM** – Displays a dialog to open installed fonts in the computer. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TKERNINGFORM** – Used in old versions when viewing or editing the legacy kerning tables (not the GPOS kerning tables). See the OpenType Designer in recent versions to edit the GPOS kerning tables.
* **TKERNINGNEWPAIRFORM** – Used when adding a kerning pair in the legacy kerning tables. The default push button is **OK**.
* **TMAINFORMFCP3** – Version 3.0 only. Used when starting FontCreator. Maximizing changes the title bar. (See TMAINFORMFONTCREATOR in recent versions)
* **TMAINFORMFONTCREATOR** – Used when starting FontCreator.
* **TMETRICSFORM** – Used when configuring metrics options. The default push button is **OK**.
* **TNAMINGFORM** – For versions 3.0 through 6.0 only, displays a dialog where you can manually change the naming fields of a font. The default push button is **OK**. See TFONTPROPERTIESFORM in recent versions.
* **TNEWTRUETYPEFONTFORM** – Used when creating a new font. The default push button is **OK**.
* **TOPTIONSFORM** – Displays a dialog where you can set a plethora of FontCreator options. The default push button is **OK**. The **Help** button does nothing in old versions.
* **TPASTESPECIALFORM** – Used when pasting data for glyphs in the clipboard. The default push button is **OK**. In the Items list (versions 5.5 through 6.0 only), Glyph Outline Data and Glyph Metrics (i.e. the first two items) are checked by default.
* **TPCLTFORM** – For versions 3.0 through 6.5 only, displays a dialog where you can include or edit the old PCL5 data for legacy printers. The default push button is **OK**.
* **TPERFORMTRANSFORMATIONFORM** – For versions 5.6 and newer, displays the Glyph Transformer. The default push button is **OK**.
* **TPLATFORMMANAGERFORM** – For versions 2.0 through 6.5 only, displays a dialog where you can choose which platform to support in the font. The default push button is **OK**.
* **TPOSTSCRIPTNAMESFORM** – Used when changing PostScript names for glyphs in the font. The default push button is **OK**.
* **TPRINTABORTFORM** – Used when the font printing is cancelled.
* **TPRINTFONTFORM** – Used when printing anything in the font.
* **TPRINTGLYPHFORM** – Used when printing a glyph.
* **TPROGRESSFORM** – Progress window. The cursor for this form is **Busy**. The default push button is **Cancel**.
* **TREGISTERFORM** – For unregistered copies of FontCreator, displays a dialog where you can enter the registration code (**Help: Register**). This removes the splash screen on startup and enables most features disabled in versions 6.0 and 8.0 until 12.0.2539 for unregistered users.
* **TRESOURCEEDITORDLG** – In old versions only, used when editing resources.
* **TSELECTCOMPOSITEGLYPHMEMBERFORM** – Used when adding glyph members to a composite glyph. The default push button is **OK**.
* **TSHAREWAREFORM** – For old versions and unregistered copies of FontCreator, displays this notice when pressing **Start** on the splash screen after the trial period is exceeded. (Only in old versions)
* **TSORTGLYPHSFORM** – Used when changing the glyph order within a font. The default push button is **OK**.
* **TSPLASHFORM** – Displays this form on startup when the Reg key is not found. The three buttons at the bottom are displayed in random order. If the trial period is exceeded, when starting the program five times it displays a random paragraph.
* **TTIPOFTHEDAYFORM** – Used in version 1.0 until 6.0 and also for newcomers and also in **Help: Tip of the Day**. FontCreator.tip will be used to display tips. On unregistered copies is a button labeled **Register**. If removed when not registered, it displays the "Access Violation". See FontCreator: Tips and Tricks in the High-Logic font forum for more details.
* **TTRANSFORMFORM** – For simple glyphs only. The default push button is **Apply**.
* **TUNICODERANGEFORM** – Used when specifying the Unicode blocks or ranges encompassed by the font file in the mappings for double-byte platforms. The default push button is **OK**.
* **TUPDATEREMINDERFORM** – Used when the program checks for updates as if **OnStartupShowUpdateReminder** is enabled. The default push button is **OK**.
* **TUSEDBYFORM** – Displays an overview of all glyphs that use the selected glyph. The default push button is **OK**.
* **TVALIDATIONWIZARDFORM** – Displays a dialog where you can validate the font for errors. The default push button is **Next**.
* **TWARNINGFORM** – Used for warnings. (See also TWIDEWARNINGFORM in new versions)
* **TWELCOMEFORM** – Used for newcomers as if **OnStartupShowWelcome** is enabled. The default push button is **OK**.
* **TWIDEMESSAGEFORM** – Used for messages.
* **TWIDEWARNINGFORM** – Used for warnings, replaces TWARNINGFORM in old versions.
