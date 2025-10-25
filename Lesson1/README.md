# Lesson 1 — Creating Walls and Understanding Rigidbody & BoxCollider2D

## Overview
In this lesson, we set up the basic game environment by creating walls and placing a ball.  
We also learned the importance of **Rigidbody2D** and **BoxCollider2D** components in Unity, which are essential for physics interactions.

---

## Steps Taken

### 1. Adding Walls
- Added **4 wall sprites** to define the boundaries of the game area.  
- **How to add a sprite:**  
  - Right-click in the **Hierarchy → 2D Object → Sprite → Square**  
- Added **BoxCollider2D** to each wall so the ball can collide with them:  
  - Select the wall in the Hierarchy  
  - Click **Add Component → Physics 2D → Box Collider 2D**  
- Used **shortcut keys** for quick duplication and placement:  
  - **Mac:** `Command + D` to duplicate  
  - **Windows:** `Ctrl + D` to duplicate  
- Rotated walls for left and right sides by **90°** to fit the orientation.  
- Positioned them carefully to form a rectangular boundary.

### 2. Ball Setup
- Added a ball inside the walls.
- Added **Rigidbody2D** to allow physics-based movement.
- Added **BoxCollider2D** to detect collisions with the walls.

### 3. Quick Controls in Unity Editor
- Used keys **Q, W, E, R, T, Y** to quickly select options while setting up walls and ball.

---

## Notes
- **Rigidbody2D** allows objects to be affected by physics (gravity, forces, collisions).  
- **BoxCollider2D** defines the shape of the object for collision detection.  
- Using duplicate (`Cmd/Ctrl + D`) and rotation helps quickly create symmetric walls.  

---

## Goal Achieved
- Game area defined with 4 walls  
- Ball placed inside with proper physics setup  
- Ready for next step: adding movement controls
