# StringWriter – Typewriter Text Utility for Unity

**StringWriter** is a small and efficient C# helper class for Unity that creates a typewriter-style text effect using **TextMeshProUGUI**.  
It gradually displays text character by character, making it ideal for dialogue systems, storytelling UI, loading hints, or any other animated text display.

---

## Features
- Simple setup with just a few lines of code  
- Adjustable writing speed  
- Optimized with `StringBuilder` for better performance  
- Fully compatible with Unity Coroutines  
- Open source under the MIT License  

---

## 🧾 How It Works
When you create a `StringWriter` instance, you provide:
1. A **TextMeshProUGUI** object (the target text element).  
2. A **string** containing the text to display.

The coroutine `writer()` appends one character at a time to the target text element, waiting a configurable amount of time between each update.  
By default, each character appears every **0.1 seconds**, but you can easily adjust this value.

---

## 💻 Example Usage

```csharp
using UnityEngine;
using TMPro;
using System.Collections;

public class ExampleUsage : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    private StringWriter stringWriter;

    void Start()
    {
        // Create a new StringWriter instance with the target text object and message
        stringWriter = new StringWriter(textUI, "Hello, this is a typewriter text effect!");

        // Start the coroutine at 0.05 seconds per character
        StartCoroutine(stringWriter.writer(0.05f));
    }
}
