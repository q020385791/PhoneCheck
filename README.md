# PhoneCheck

## Overview / ���z
`PhoneCheck` is a Windows Forms application designed for searching and displaying phone numbers based on department and unit keywords. It provides an interface to input keywords and view the corresponding results in a `ListBox`.

`PhoneCheck` �O�@�� Windows Forms ���ε{���A���b�ھڳ����M�������r�j�M����ܹq�ܸ��X�C�����ѤF�@�Ӥ����A���\��J����r�æb `ListBox` ���d�ݹ��������G�C

## Features / �\��
- Search for phone numbers by department keyword.
- �ھڳ�������r�j�M�q�ܸ��X�C
- Search for phone numbers by unit keyword.
- �ھڳ������r�j�M�q�ܸ��X�C
- Combined search functionality for both department and unit keywords.
- �䴩�����M�������r���զX�j�M�\��C
- Display search results in the format: `Department_Name_Unit_Phone`.
- �H�榡 `����_�W��_���_�q��` ��ܷj�M���G�C

## Project Structure / �M�׵��c
- **Form1.cs**: The main form that handles the UI and search operations.
- **Form1.cs**�G�B�z UI �M�j�M�ާ@���D�n���C
- **Service.cs**: Contains methods for reading phone data from a JSON file and filtering results based on department or unit keywords.
- **Service.cs**�G�]�t�q JSON ���Ū���q�ܸ�ƨîھڳ����γ������r�L�o���G����k�C
- **Model.cs**: Defines the data structure for departments and units.
- **Model.cs**�G�w�q�����M��쪺�ƾڵ��c�C
- **Phonelist.txt**: A JSON file used to store phone data.
- **Phonelist.txt**�G�Ω�s�x�q�ܼƾڪ� JSON ���C

## Model Structure / Model ���c
### Model Class / Model ��
- **Dep (string)**: Represents the department name.
- **Dep (string)**�G��ܳ����W�١C
- **lsUnit (List<Unit>)**: A list of units within the department.
- **lsUnit (List<Unit>)**�G�����������C��C

### Unit Class / Unit ��
- **Name (string)**: Represents the name of the unit.
- **Name (string)**�G��ܳ��W�١C
- **Phones (List<string>)**: A list of phone numbers associated with the unit.
- **Phones (List<string>)**�G�P���������q�ܸ��X�C��C

## Usage / �ϥΤ覡
1. **Load Phone Data**: The application reads phone data from `Phonelist.txt` located in the current directory.
1. **���J�q�ܸ��**�G���ε{���q��e�ؿ����� `Phonelist.txt` ��Ū���q�ܸ�ơC
2. **Search Functionality**:
   - Enter a department keyword in the `txtDepkeyword` textbox to filter results by department.
   - �b `txtDepkeyword` ��J�ؤ���J��������r�H�ھڳ����L�o���G�C
   - Enter a unit keyword in the `txtRoomkeyword` textbox to filter results by unit.
   - �b `txtRoomkeyword` ��J�ؤ���J�������r�H�ھڳ��L�o���G�C
   - Results are displayed in the `lsbPhone` ListBox in the format `Department_Name_Unit_Phone`.
   - �j�M���G�H `����_�W��_���_�q��` ���榡��ܦb `lsbPhone` �C��ؤ��C

## Code Details / �N�X�Ա�

### Form1.cs
- Contains the main UI logic.
- �]�t�D�n�� UI �޿�C
- Handles `TextChanged` events for the `txtDepkeyword` and `txtRoomkeyword` textboxes to trigger the search.
- �B�z `txtDepkeyword` �M `txtRoomkeyword` ��J�ت� `TextChanged` �ƥ�HĲ�o�j�M�C
- Uses the `ModelTolsb` method to display the search results in `lsbPhone`.
- �ϥ� `ModelTolsb` ��k�N�j�M���G��ܦb `lsbPhone` ���C

### Service.cs
- Provides methods for:
- ���ѥH�U��k�G
  - Loading phone data from `Phonelist.txt`.
  - �q `Phonelist.txt` ���J�q�ܸ�ơC
  - Filtering data by department (`GetlsPhoneByDep`), by unit (`GetlsPhoneByRoom`), and by a combination of both (`GetlsPhoneByDepAndRoom`).
  - �ھڳ��� (`GetlsPhoneByDep`)�B��� (`GetlsPhoneByRoom`) �M��̲զX (`GetlsPhoneByDepAndRoom`) �L�o��ơC
- `SampleObjectToJson` method for generating sample JSON data.
- `SampleObjectToJson` ��k�Ω�ͦ��ܨ� JSON ��ơC

## JSON Structure / JSON ���c
`Phonelist.txt` contains data in the following structure:
`Phonelist.txt` �]�t�H�U���c����ơG

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
