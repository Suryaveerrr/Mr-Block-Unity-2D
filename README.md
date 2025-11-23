# 🟥 Mr. Blocks: 2D Platformer

![Unity](https://img.shields.io/badge/Unity-2021.3%2B-black?style=flat&logo=unity)
![Genre](https://img.shields.io/badge/Genre-2D%20Platformer-blue)
![Input](https://img.shields.io/badge/Input-Keyboard-grey)

> **Precision movement. Deadly spikes. One way out.**

**Mr. Blocks** is a 2D maze-based platformer built in Unity. It focuses on tight player controls, obstacle navigation, and a clean UI/UX loop. The goal is simple: navigate the maze, avoid the traps, and reach the finish line.

---

## 📸 Gallery

| Main Menu | Gameplay | Game Over |
| :---: | :---: | :---: |
| ![Main Menu](https://github.com/user-attachments/assets/f8b7d834-19bd-4768-85af-73550167b61f) | ![Gameplay](https://github.com/user-attachments/assets/0b08880a-996e-4bc3-9670-37c2add0496b) | ![Game Over](https://github.com/user-attachments/assets/d04e47c1-3a96-432a-81f1-fe0576f74687) |

---

## ✨ Key Features

* **Responsive Movement:** Physics-based controller using standard keyboard inputs.
* **Maze Design:** Levels designed with static obstacles (spikes) requiring precision to navigate.
* **Game Loop:** Full state management including Main Menu, Gameplay, Level Completion, and Game Over states.
* **Audio System:** Centralized `SoundManager` handling background music and SFX feedback.
* **UI/UX:** Clean interface using **TextMeshPro** for crisp text rendering and smooth scene transitions.

---

## 🎮 How to Play

**Objective:** Reach the finish flag without touching any spikes.

| Action | Controls |
| :--- | :--- |
| **Move** | <kbd>W</kbd><kbd>A</kbd><kbd>S</kbd><kbd>D</kbd> or <kbd>Arrow Keys</kbd> |
| **Interact** | UI Buttons (Mouse Click) |

**Rules:**
1.  Launch the game from the **Main Menu**.
2.  Navigate the maze.
3.  **Spikes are instant death.** If you hit one, the Game Over screen triggers.
4.  Reach the green flag to win.

---

## ⚙️ Technical Implementation

* **Scene Management:** Uses Unity's `SceneManager` to handle loading between Menu, Game, and Restart logic efficiently.
* **Singleton Pattern:** Implemented for the Audio System to ensure music persists smoothly across scene loads.
* **Canvas UI:** anchored layouts to ensure buttons and text remain readable across different aspect ratios.

---
