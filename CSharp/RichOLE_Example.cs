public static void Main() {
  RichTextBox richBox = new RichTextBox();
  RichOLE richOLE = new RichOLE(richBox);
  richOLE.EnableUndo(false);
  // events that will not go to the UNDO/REDO stack
  richOLE.EnableUndo(true);
  
  // ...
}
