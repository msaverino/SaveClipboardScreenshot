# Configuration File Usage

## JSON Configuration File for File Saving

### Description

This JSON configuration file is used for specifying the directory and file naming convention for saving files.

### Configuration Parameters

- **Folder**: The directory where the files will be saved.
- **Suffix**: The naming convention for the files, which can be "Increment", "Date", "DateTime", or "Random".

### Example
```json
{
  "Folder": "C:\\Users\\Public\\Documents\\",
  "CreateChildFolder": true,
  "Suffix": "Increment"
}
```

## CreateChildFolder option

- **CreateChildFolder**: If this option is set to true, a child folder will be created in the specified directory. The name of the child folder will be the prefix designated within the GUI.

## Suffix Configuration File Options
- **Increment**: The file name will be incremented by 1 each time a file is saved.
- **Date**: The file name will be the current date.
- **Time**: The file name will be the current time.
- **DateTime**: The file name will be the current date and time.
- **Random**: The file name will be a random string of characters.
- **Custom**: The file name will be a custom string of characters.