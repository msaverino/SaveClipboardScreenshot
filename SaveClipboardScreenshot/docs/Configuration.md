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
  "Suffix": "Increment"
}
```

## Suffix Configuration File Options
- **Increment**: The file name will be incremented by 1 each time a file is saved.
- **Date**: The file name will be the current date.
- **DateTime**: The file name will be the current date and time.
- **Random**: The file name will be a random string of characters.
- **Custom**: The file name will be a custom string of characters.