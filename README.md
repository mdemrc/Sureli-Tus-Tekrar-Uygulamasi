# Timed Key Repeat Trainer Console (`Sureli-Tus-Tekrar-Uygulamasi`)

[![Windows API](https://img.shields.io/badge/API-user32-blue)](https://learn.microsoft.com/windows/win32/api/winuser/nf-winuser-keybd_event)

## English

Teaching aid for **keyboard automation ethics**: prompts for **interval \(\seconds\)** and **capture of a keystroke**, then repeatedly synthesises presses using **`user32.dll` `keybd_event` P/Invoke**. Includes cooperative cancellation \(\`dur command\`). Stress that hooking keystrokes improperly may violate workstation policies \(disclose responsibly in portfolio narrative\).

Build with `dotnet run` or VS solution hosting `Program.cs`; no SQL dependencies.

---

## Türkçe

Konsol uygulaması **saniye aralığı** ve **bir tuş yakalayıp** `Thread.Sleep` ile oluşturulan döngüyle **Windows `keybd_event` API** çağrısı üzerinden tuş basımı üretir. **`dur`** yazarak döngüyü güvenle bitirirsiniz (giriş satırında küçük harf `dur` kontrolü vardır).

Bu tür araçların kötüye kullanılmaması, şirket veya sınav sırasında uygulanan İK ilkelerini ihlâl etmemesi gerekir; portföyde bağlamı açıklayınız.
