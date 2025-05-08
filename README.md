# Editor-txt

## 📖 Introduction
**Editor-txt** is a simple and functional text editor developed in **C#** using **Windows Forms**. This project is designed to provide an intuitive and user-friendly interface for performing basic text editing operations.

## ✨ Features
The text editor provides the following functionalities:

### File Menu:
- **New**:
  - Create a new blank document.
- **New Window**:
  - Open a new instance of the text editor in a separate window.
- **Open**:
  - Open existing text files (.txt) or other supported file types.
- **Save**:
  - Save modifications made to the current file.
- **Save As**:
  - Save the document with a new name or in a different directory.
- **Exit**:
  - Close the application with an option to confirm before exiting.

### Edit Menu:
- **Undo**:
  - Revert the last change made to the text.
- **Redo**:
  - Reapply the last undone change.
- **Cut**:
  - Cut the selected text and copy it to the clipboard.
- **Copy**:
  - Copy the selected text to the clipboard.
- **Paste**:
  - Paste the clipboard's content at the current cursor position.
- **Delete**:
  - Delete the selected text without copying it to the clipboard.
- **Insert Date and Time**:
  - Insert the current date and time at the cursor position.

### Additional Features:
- **File Management**:
  - Automatically manages file paths, default names, and extensions (.txt).
- **Error Handling**:
  - Displays user-friendly error messages in case of issues with file operations (e.g., opening or saving files).
- **Responsive Interface**:
  - Dynamically updates the state of menu options based on the editing context (e.g., enabling "Save" when changes are detected).

## 🚀 How to Use
1. Clone the repository:
   ```bash
   git clone https://github.com/4RCarteri/Editor-txt.git
   ```
2. Open the project in **Visual Studio**.
3. Build and run the project.
4. Use the menu at the top of the application to access all available features.

## 🛠 Project Structure
- **`Program.cs`**:
  - Entry point of the application, responsible for initializing the main form.
- **`Form1.cs`**:
  - Implements the graphical interface and all the functionalities of the editor.
- **`Manager.cs`**:
  - Provides default settings and manages file-related operations such as paths and names.

## 🤝 Contributions
Contributions are welcome! Follow these steps:
1. Fork the repository.
2. Create a branch for your feature: `git checkout -b my-feature`.
3. Commit your changes: `git commit -m 'Add new feature'`.
4. Push your branch: `git push origin my-feature`.
5. Open a Pull Request.

## 📄 License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.