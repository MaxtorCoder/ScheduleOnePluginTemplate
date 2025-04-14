# Schedule I Plugin Project Template

A customizable project template for building **Schedule I plugins** using either **BepInEx** or **MelonLoader** modding frameworks.
Built with flexibility for Unity integration, this template provides a clean starting point for mod developers targeting Schedule I game.

---

## Features
- **Mod Loader Support**: Easily switch between BepInEx and MelonLoader
- **Unity Integration**: Optional support for Unity script projects
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
dotnet new s1_plugin \
  --modloader BepInEx \
  --gameroot "C:/Path/To/ScheduleIGame" \
  --unityroot "C:/Path/To/UnityProject" # optional
```

### Parameters
| Name         | Required | Description                                                  |
|--------------|----------|--------------------------------------------------------------|
| `modloader`  | Yes      | Modding framework to use (`BepInEx` or `MelonLoader`)        |
| `gameroot`   | Yes      | Path to the Schedule I game root folder                      |
| `unityroot`  | No       | Path to Unity project root (include Unity scripts if filled) |

---

## Template Metadata
- **Template Name**: Schedule I Plugin Project Template
- **Short Name**: `s1_plugin`
- **Author**: MaxtorCoder
- **Tags**: `project`, `C#`, `Unity`, `Mono`, `MelonLoader`, `BepInEx`

---

## License
This project is licensed under the [MIT](https://opensource.org/license/MIT) License.

---

## Contributions
PRs, issues, and suggestions are welcome. Help improve the template for the community!