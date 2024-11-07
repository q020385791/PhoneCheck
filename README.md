# PhoneCheck

## Overview / 概述
`PhoneCheck` is a Windows Forms application designed for searching and displaying phone numbers based on department and unit keywords. It provides an interface to input keywords and view the corresponding results in a `ListBox`.

`PhoneCheck` 是一個 Windows Forms 應用程式，旨在根據部門和單位關鍵字搜尋並顯示電話號碼。它提供了一個介面，允許輸入關鍵字並在 `ListBox` 中查看對應的結果。

## Features / 功能
- Search for phone numbers by department keyword.
- 根據部門關鍵字搜尋電話號碼。
- Search for phone numbers by unit keyword.
- 根據單位關鍵字搜尋電話號碼。
- Combined search functionality for both department and unit keywords.
- 支援部門和單位關鍵字的組合搜尋功能。
- Display search results in the format: `Department_Name_Unit_Phone`.
- 以格式 `部門_名稱_單位_電話` 顯示搜尋結果。

## Project Structure / 專案結構
- **Form1.cs**: The main form that handles the UI and search operations.
- **Form1.cs**：處理 UI 和搜尋操作的主要表單。
- **Service.cs**: Contains methods for reading phone data from a JSON file and filtering results based on department or unit keywords.
- **Service.cs**：包含從 JSON 文件中讀取電話資料並根據部門或單位關鍵字過濾結果的方法。
- **Model.cs**: Defines the data structure for departments and units.
- **Model.cs**：定義部門和單位的數據結構。
- **Phonelist.txt**: A JSON file used to store phone data.
- **Phonelist.txt**：用於存儲電話數據的 JSON 文件。

## Model Structure / Model 結構
### Model Class / Model 類
- **Dep (string)**: Represents the department name.
- **Dep (string)**：表示部門名稱。
- **lsUnit (List<Unit>)**: A list of units within the department.
- **lsUnit (List<Unit>)**：部門內的單位列表。

### Unit Class / Unit 類
- **Name (string)**: Represents the name of the unit.
- **Name (string)**：表示單位名稱。
- **Phones (List<string>)**: A list of phone numbers associated with the unit.
- **Phones (List<string>)**：與單位相關的電話號碼列表。

## Usage / 使用方式
1. **Load Phone Data**: The application reads phone data from `Phonelist.txt` located in the current directory.
1. **載入電話資料**：應用程式從當前目錄中的 `Phonelist.txt` 中讀取電話資料。
2. **Search Functionality**:
   - Enter a department keyword in the `txtDepkeyword` textbox to filter results by department.
   - 在 `txtDepkeyword` 輸入框中輸入部門關鍵字以根據部門過濾結果。
   - Enter a unit keyword in the `txtRoomkeyword` textbox to filter results by unit.
   - 在 `txtRoomkeyword` 輸入框中輸入單位關鍵字以根據單位過濾結果。
   - Results are displayed in the `lsbPhone` ListBox in the format `Department_Name_Unit_Phone`.
   - 搜尋結果以 `部門_名稱_單位_電話` 的格式顯示在 `lsbPhone` 列表框中。

## Code Details / 代碼詳情

### Form1.cs
- Contains the main UI logic.
- 包含主要的 UI 邏輯。
- Handles `TextChanged` events for the `txtDepkeyword` and `txtRoomkeyword` textboxes to trigger the search.
- 處理 `txtDepkeyword` 和 `txtRoomkeyword` 輸入框的 `TextChanged` 事件以觸發搜尋。
- Uses the `ModelTolsb` method to display the search results in `lsbPhone`.
- 使用 `ModelTolsb` 方法將搜尋結果顯示在 `lsbPhone` 中。

### Service.cs
- Provides methods for:
- 提供以下方法：
  - Loading phone data from `Phonelist.txt`.
  - 從 `Phonelist.txt` 載入電話資料。
  - Filtering data by department (`GetlsPhoneByDep`), by unit (`GetlsPhoneByRoom`), and by a combination of both (`GetlsPhoneByDepAndRoom`).
  - 根據部門 (`GetlsPhoneByDep`)、單位 (`GetlsPhoneByRoom`) 和兩者組合 (`GetlsPhoneByDepAndRoom`) 過濾資料。
- `SampleObjectToJson` method for generating sample JSON data.
- `SampleObjectToJson` 方法用於生成示例 JSON 資料。

## JSON Structure / JSON 結構
`Phonelist.txt` contains data in the following structure:
`Phonelist.txt` 包含以下結構的資料：

```json
[
  {
    "Dep": "Department1",
    "lsUnit": [
      {
        "Name": "Unit1",
        "Phones": ["Phone1"]
      },
      {
        "Name": "Unit2",
        "Phones": ["Phone2", "Phone3"]
      }
    ]
  },
  {
    "Dep": "Department2",
    "lsUnit": [
      {
        "Name": "Unit3",
        "Phones": ["Phone4"]
      }
    ]
  }
]
