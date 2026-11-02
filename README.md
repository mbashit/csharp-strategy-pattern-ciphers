# Strategy Pattern — Text Ciphers (C#)

![C#](https://img.shields.io/badge/C%23-.NET-512BD4?logo=dotnet) ![Pattern](https://img.shields.io/badge/pattern-Strategy-informational)

A console application that demonstrates the **Strategy design pattern** by swapping encryption algorithms at runtime behind a single interface.

## Features

- **Caesar cipher** — shifts letters by a configurable offset, preserving case and non-letters
- **XOR cipher** — encodes each character with a single-character key
- **Reverse cipher** — reverses the input text
- Interactive menu loop with input validation

## Design

```
            ┌──────────────────────┐
            │ IEncryptionStrategy  │  string encode(string)
            └──────────▲───────────┘
       ┌───────────────┼───────────────┐
 CaesarCipher      XorCipher      ReverseCipher

 Encryptor ── holds an IEncryptionStrategy, setStrategy() swaps it at runtime
```

`Encryptor` (the *context*) never knows which algorithm it uses — new ciphers can be added without changing existing code (Open/Closed Principle).

## Project structure

| File | Responsibility |
|---|---|
| `ООАП1/Program.cs` | Console menu and user input |
| `ООАП1/Encryptor.cs` | Context class delegating to the current strategy |
| `ООАП1/EncryptionStrategies.cs` | `IEncryptionStrategy` and the three cipher implementations |

## Run

```bash
cd ООАП1
dotnet run
```

## What I learned

- Applying the Strategy pattern to decouple *what* is done from *how* it is done
- Programming to interfaces and composition over inheritance
- Character arithmetic and `StringBuilder` for efficient string building

*Built for the Object-Oriented Analysis & Design (ООАП) course.*
