# Schedule I Plugin Project Template

A customizable project template for building **Schedule I plugins** using both **BepInEx** and **MelonLoader** modding frameworks, adding easy integration for Unity as well to create custom asset bundles.

---

## Features
- **Mod Loader Support**: Easily switch between BepInEx and MelonLoader through Build Configurations (change your Schedule 1 root accordingly to load files)
- **Unity Integration**: Optional support for Unity script projects to create asset bundles
---

## Usage

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.
- Knowledge of either BepInEx or MelonLoader modding frameworks.

### Installation
To install the template, run the following command:

```bash
dotnet new install MaxtorCoder.ScheduleIPluginProjectTemplate
```

### Creating a New Project

```bash
dotnet new s1_plugin -n "ModName" \
  --gameroot "C:/Path/To/ScheduleIGame" \
  --unityroot "C:/Path/To/UnityProject" # optional
```

### Parameters
| Name         | Required | Description                                                  |
|--------------|----------|--------------------------------------------------------------|
| `gameroot`   | Yes      | Path to the Schedule I game root folder                      |
| `unityroot`  | No       | Path to Unity project root (include Unity scripts if filled) |

---

## License
This project is licensed under the [MIT](https://opensource.org/license/MIT) License.

---

## Contributions
PRs, issues, and suggestions are welcome. Help improve the template for the community!