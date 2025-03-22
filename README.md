
# **GDI-GUI**

A **visual-only** "malware" creator designed for pranks, educational demonstrations, or just for fun. It generates fake malware-like effects to create a harmless scare.

**Features:**  
- 13 different payloads
- Customizability
- Extra options to ensure the payload is seen

**Disclaimer:**  
This software is purely for entertainment and educational use. It does not contain any actual malicious code and should not be used for unethical purposes. (blah blah blah)

⚠ **Note:** A working `g++` compiler is required. If `g++` is not installed, the program will fail to compile.  
## **How Does It Work?**  

~~Read through the code~~

The program contains a built-in c++ stub that contains every payload. Then, depending on your choices, it will embed the selected payloads and apply the configured settings before compiling the final output.  

## **Installation**  

There is no installation required—unless you don’t have a `g++` compiler installed. If that's the case, follow these steps:  

### **Installing MinGW (g++) on Windows**

1. Go to [winLibs](https://winlibs.com/).  
2. Scroll down to the section titled **"Help! I don't know which download to choose!"**  
3. Click the **"here"** link to download the latest version of MinGW.  
4. Extract the downloaded file to `C:\mingw64`. Your path should now look like this:  
   ```
   C:\mingw64
   ```  
5. Add the `bin` folder to your system's PATH:  
   - Open **Environment Variables**  
   - Under **System Variables**, find and edit **Path**  
   - Click **New** and add:  
     ```
     C:\mingw64\bin
     ```  

### **Troubleshooting Installation**  

If the latest MinGW version doesn’t work, try using [this specific version](https://github.com/brechtsanders/winlibs_mingw/releases/download/14.2.0posix-12.0.0-ucrt-r3/winlibs-x86_64-posix-seh-gcc-14.2.0-llvm-19.1.7-mingw-w64ucrt-12.0.0-r3.7z), which was used to build this program.  

Still having issues? Try looking up a YouTube tutorial or asking a friend for help — I’m not the best at explaining things, sorry## **Features**  

### **Payloads**  
- **Tunnel** – The classic screen tunneling effect
- **DVD Ball** *(Customizable)* – The classic bouncing DVD logo  
- **DVD Text** *(Customizable)* – Same as above, but with text  
- **Rainbow Puke** – Flood the screen with vibrant colors  
- **Static** – Classic TV-style noise effect
- **Fractal** – Expanding trippy patterns  
- **Growing Squares** – Squares that just won’t stop multiplying
- **Smear** – Smudges the screen around
- **Invert Squares** – Inverts screen colors in random squares  
- **Invert Spam** – Very fast full screen invert  
- **Icon Spam** – Floods the screen with random icons
- **Shake** – Makes your screen go wild with vibrations
- **Runaway Screen** *(Customizable)* – Makes the screen scroll diagonally

---

### Other Options

- **Effect Duration** – Set how long each effect lasts
- **Run Synchronously** – Activate **all** effects at once  
- **Clear Screen** – Closes all windows to maximize impact
- **Kill Wallpaper** – Prevent live wallpapers from interfering  
- **Block Input** *(Requires Admin)* – Locks keyboard and mouse

## **Compiler Errors**  

Sometimes you might encounter compiler errors. Below are known issues and their fixes.  

If you run into an error **not listed here**, please report it, and I'll look into a fix.

### **Error:** `'GetTickCount64' was not declared in this scope`  
**Cause:** Your `g++` compiler is outdated.  

**Solution:** Update your compiler by following the **[Installation Guide](#installation)** above.  
