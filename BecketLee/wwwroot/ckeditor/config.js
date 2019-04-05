/**
 * @license Copyright (c) 2003-2017, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see LICENSE.md or http://ckeditor.com/license
 */

CKEDITOR.editorConfig = function( config ) {
	config.toolbarGroups = [
		{ name: 'document', groups: [ 'mode', 'document', 'doctools' ] },
		{ name: 'tools', groups: [ 'tools' ] },
		{ name: 'clipboard', groups: [ 'clipboard', 'undo' ] },
		{ name: 'editing', groups: [ 'find', 'selection', 'spellchecker', 'editing' ] },
		{ name: 'forms', groups: [ 'forms' ] },
		{ name: 'paragraph', groups: [ 'blocks', 'list', 'indent', 'bidi', 'paragraph' ] },
		'/',
		{ name: 'basicstyles', groups: [ 'basicstyles', 'align', 'cleanup' ] },
		{ name: 'links', groups: [ 'links' ] },
		{ name: 'insert', groups: [ 'insert' ] },
		{ name: 'colors', groups: [ 'colors' ] },
		{ name: 'styles', groups: [ 'styles' ] },
		{ name: 'others', groups: [ 'others' ] },
		{ name: 'about', groups: [ 'about' ] }
	];

	config.removeButtons = 'Print,Preview,NewPage,Save,Templates,Form,Checkbox,Radio,TextField,Textarea,Select,Button,HiddenField,CopyFormatting,RemoveFormat,BidiLtr,BidiRtl,Language,Anchor,Flash,Smiley,PageBreak,About,Superscript,Strike,Subscript,Blockquote,CreateDiv,Image,SpecialChar,Iframe,ShowBlocks,Font,BGColor,Undo,Redo,Styles';
};

// The toolbar groups arrangement, optimized for two toolbar rows.
//config.toolbarGroups = [
//	{ name: 'clipboard',   groups: [ 'clipboard', 'undo' ] },
//	{ name: 'editing',     groups: [ 'find', 'selection', 'spellchecker' ] },
//	{ name: 'links' },
//	{ name: 'insert' },
//	{ name: 'forms' },
//	{ name: 'tools' },
//	{ name: 'document',	   groups: [ 'mode', 'document', 'doctools' ] },
//	{ name: 'others' },
//	'/',
//	{ name: 'basicstyles', groups: [ 'basicstyles', 'cleanup' ] },
//	{ name: 'paragraph',   groups: [ 'list', 'indent', 'blocks', 'align', 'bidi' ] },
//	{ name: 'styles' },
//	{ name: 'colors' },
//	{ name: 'about' }
//];

// Remove some buttons provided by the standard plugins, which are
// not needed in the Standard(s) toolbar.
//config.removeButtons = 'Underline,Subscript,Superscript,ImageButton,';

// Set the most common block elements.
//config.format_tags = 'p;h1;h2;h3;pre';

// Simplify the dialog windows.?
//config.removeDialogTabs = 'image:advanced;link:advanced';