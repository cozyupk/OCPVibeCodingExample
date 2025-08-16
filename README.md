OCP Vibe Coding Example
=======================

> _Built the 2nd floor by hand, then let GPT expand it into a 6-floor building — OCP vibe coding in action._ 🏗️✨

Overview
--------

This repository demonstrates an experimental style of **"vibe coding"**:  
a human developer sets up the foundation using the **Open/Closed Principle (OCP)**, and a generative AI assistant extends it further while keeping the design open for extension and closed for modification.

The project evolves from a minimal **time unit system** (seconds and minutes) into a full **Gregorian calendar** representation including:

*   Seconds
    
*   Minutes
    
*   Hours
    
*   Days (with leap year support)
    
*   Months
    
*   Years (0001–9999, clamped)
    

Key Ideas
---------

*   **OCP in practice** – each time unit is an independent class, open to extension by chaining to the next unit.
    
*   **Human + AI collaboration** – [initial 2 levels (Seconds, Minutes) were written manually](./src/HumanAuthored), while [higher units (Hours → Years) were generated and refined through AI guidance](./src/VibeCoded).
    
*   **Composable architecture** – `Increment()` cascades through units, and `AsString()` builds a readable `YYYY-MM-DD HH:mm:ss` output.
    

Example Output
--------------

```text
0001-01-01 00:00:00
0001-01-01 00:00:01
...
2025-08-16 14:07:59
```

Requires To Build and Run
----------

Requires **.NET 8.0** or later.

Why "Vibe Coding"?
------------------

Because the process wasn’t a strict spec-driven implementation.  
It was more like _“set the vibe, let AI riff on it, then polish together”_.  
Think of it as **pair-programming with a generative AI**, where OCP provides the safety rails.

License
-------

This project is licensed under the **MIT License**.  
Note: Parts of the code were generated with the assistance of **OpenAI’s GPT model**, and then reviewed/modified by a human developer.  
You are free to use, modify, and distribute this project under the terms of the MIT License.

