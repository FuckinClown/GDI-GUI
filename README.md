
# GDI-GUI

A visuals creator for fun. No payload is harmful, its all for show

If you like this project please star the repo so I know what you think



## How does it work?

There is a stub within the main program, based on the options you click there, it will add the selected payloads to the final product with the settings you choose.

If you do not have a g++ compiler installed, it will error.

## Install

There is no install unless g++ isnt installed, then follow these instructions:

1. Go to [winLabs](https://winlibs.com/)
2. Scroll down until you see *Help! I don't know which download to choose!*
3. Click the download link that says *here*, this is the latest version of mingw
4. Extract the file into your C drive so that the path reads as: C:\mingw64
5. Add the bin folder to your path: Environment Variables -> System Variables -> Path -> Edit -> New -> C:\mingw64\bin

 
If the latest version does not work, download [this version](https://github.com/brechtsanders/winlibs_mingw/releases/download/14.2.0posix-12.0.0-ucrt-r3/winlibs-x86_64-posix-seh-gcc-14.2.0-llvm-19.1.7-mingw-w64ucrt-12.0.0-r3.7z), I used this while building the program

If you are still stuck, please refer to a youtube video or friend's help. Sorry I am not the best at explaining or helping people.


## Features

### Payloads
- Tunnel
- DVD Ball
- DVD Text [Customizable]
- Rainbow Puke
- Static
- Fractal
- Growing Shapes
- Smear
- Invert Squares
- Invert Spam
- Icon Spam
- Shake
### Other Options
- Effect Duration | How long each effect lasts
- Run Synchronously | Runs everything at once
- Clear Screen | Closes all windows to maxamize effect
- Kill wallpaper | Live wallpapers mess with the effects
- Block Input | **Requires admin**


## Compiler Errors

"Randomly" you will get a compiler error, here are known fixes

if you get an error that is not on this list, please make a report and I will find a fix

#### GetTickCount64
How to fix : 
` error: 'GetTickCount64' was not declared in this scope`

Your g++ compiler is too old and needs to be updated, please refer to the Install help above
