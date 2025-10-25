# Lesson 1 — Adding Ball Movement

## Overview
In this step, we learned how to make the ball move using keyboard input.  
We also learned how to attach a script to a GameObject and how to fix input issues in Unity.

---

## Steps Learned

### 1. Attaching a Script
- Create a C# script inside **Assets → Scripts** (right-click → Create → C# Script).  
- Name it `BallMovement.cs`.  
- To attach the script to the ball:
  1. Select the ball GameObject in the Hierarchy.  
  2. Click **Add Component → Scripts → BallMovement**.  
- Now the ball knows which script controls its behavior.

---

### 2. Writing the Script
- Open the script in Visual Studio or your code editor.  
- We wrote code to move the ball with the keyboard:

```csharp
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY).normalized;
        rb.velocity = movement * speed;
    }
}

# Explanation of the Script

- **`public float speed`** → Sets how fast the ball moves.
- **`Rigidbody2D rb = GetComponent<Rigidbody2D>()`** → Gets the Rigidbody2D component attached to the ball.
- **`Input.GetAxis("Horizontal") / "Vertical"`** → Reads keyboard input (WASD or arrow keys).
- **`Vector2 movement = new Vector2(moveX, moveY).normalized`** → Creates a direction vector and normalizes it so diagonal movement isn’t faster.
- **`rb.velocity = movement * speed`** → Moves the ball using physics for smooth collisions.

---

## Fixing Input Issue

If you get this error:
InvalidOperationException: You are trying to read Input using the UnityEngine.Input class,
but you have switched active Input handling to Input System package in Player Settings.


Fix it by switching back to the **old Input Manager** (simpler for beginners):

1. Go to **Edit → Project Settings → Player → Other Settings → Active Input Handling**  
2. Change it to **Input Manager (Old)** or **Both**  
3. Click **Apply**, then restart Unity if needed.

---

## Goal Achieved

- Ball can now move smoothly using keyboard input.  
- Learned how to attach a script and write beginner-friendly movement code.  
- Fixed input system issues for old-style Input methods.
