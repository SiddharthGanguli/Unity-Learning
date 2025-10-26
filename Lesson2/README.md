# Unity Main Menu Scene – Responsive UI & Animated Background

## Overview
This Unity mini-project focuses on building a main menu with two key goals:

- Creating a responsive UI that works on all screen sizes and aspect ratios
- Adding a smooth looping animated background using Unity’s Animation System

The menu includes two centered buttons — **Start** and **Exit** — with a color-changing animated background.

---

## Step 1 – Making the UI Responsive

### Goal
Ensure that all UI elements scale and stay positioned correctly on any resolution, including desktop, tablet, mobile, and ultrawide screens.

### What I Did
1. Created a **Canvas** and added **Start** and **Exit** buttons
2. Set **Canvas Scaler → UI Scale Mode** to:  
   `Scale With Screen Size`
3. Set **Reference Resolution** to: `1920 x 1080`
4. Set **Screen Match Mode** to `Match Width Or Height` with **Match = 0.5**
5. Used **Anchor Presets (Alt + Shift)** to center the UI elements
6. Tested multiple aspect ratios (16:9, 4:3, 21:9, etc.)

### What I Learned
- Canvas Scaler makes UI resolution-independent
- Anchors control how elements reposition on screens
- A single UI layout can work across all devices

### Result
The Start and Exit buttons remain centered and balanced in every resolution.

---

## Step 2 – Adding the Background

### What I Did
1. Added a **UI → Image** named `Background`
2. Set **Anchors to Stretch (Both)** so it always fills the screen
3. Assigned a base color before animation

This background will later be animated to create a color-changing effect.

---

## Step 3 – Creating a Button Group with Automatic Layout

### Goal
Keep the buttons centered and evenly spaced without manual positioning.

### What I Did
1. Created an **Empty GameObject** under the Canvas named `ButtonGroup`
2. Set **Anchors to Middle-Center**
3. Added a **Vertical Layout Group** and enabled:
   - Child Alignment: *Middle Center*
   - Control Child Size (Width and Height)
   - Child Force Expand (Width and Height)
4. (Optional) Added **Content Size Fitter**:
   - Horizontal Fit → Preferred Size
   - Vertical Fit → Preferred Size
5. Placed `StartButton` and `ExitButton` inside `ButtonGroup`
6. Adjusted spacing in the Vertical Layout Group for visual balance

### What I Learned
- Vertical Layout Group automatically aligns and spaces UI elements
- No need to drag and position buttons manually

---

## Step 4 – Adding the Animated Background

### What I Did
1. Opened **Animation Window**
2. Created `BackgroundColor.anim`
3. Added keyframes for the Image **Color** property (e.g., Blue → Purple → Teal → Blue)
4. Enabled **Loop Time**
5. Used an **Animator Controller** to run the animation on start

### Result
The background now loops through smooth color transitions, adding visual motion to the menu.

---

## Concepts Practiced

| Concept | Description |
|---------|------------|
| Canvas Scaler | Makes UI resolution-independent |
| Anchors & Pivot | Controls UI layout behavior |
| Vertical Layout Group | Automatically aligns and spaces UI elements |
| Animation Window | Creates keyframe-based UI animations |
| Animator Controller | Handles animation playback and looping |

---

## Next Steps
- Add hover and click animations for buttons
- Add sound effects to button clicks
- Add animated scene transitions
- Experiment with particle backgrounds

---

## Tools Used
- Unity 6 (2023 LTS)
- C# for button functionality
- Unity Animator + Animation Window
- Unity UI Toolkit (Canvas, Buttons, Image)

---

## Summary

| Topic | Skills Learned |
|--------|---------------|
| Responsive UI | Canvas Scaler, Anchors, Layout Groups |
| UI Animation | Keyframes, Animator, Looping |
| Unity UI Basics | Inspector, Hierarchy, Resolution Testing |
| Project Structure | Main Menu setup for future scenes |

---

## Author
**Siddhartha Ganguli**  
AI/ML Engineering Student | Game Development Learner | Exploring AI + Game Design Integration
