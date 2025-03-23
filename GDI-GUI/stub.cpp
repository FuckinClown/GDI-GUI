#define _WIN32_WINNT 0x0600
#include <windows.h>
#include <iostream>
#include <cmath>
#include <time.h>
#include <thread>
#if KILL_WALLS
#include <cstdlib>  // For system(), prob detected lmao
#endif
#pragma comment(lib, "winmm.lib")
// Dont forget to close the door when you leave
typedef union _RGBQUAD {
    COLORREF rgb;
    struct {
        BYTE b;
        BYTE g;
        BYTE r;
        BYTE unused;
    };
} *PRGBQUAD;

typedef union COLOR {
    COLORREF rgb;
    struct {
        BYTE blue;
        BYTE green;
        BYTE red;
    };
} COLOR;

int cnt = 0;
int screenWidth = GetSystemMetrics(SM_CXSCREEN);
int screenHeight = GetSystemMetrics(SM_CYSCREEN);

int GetRainbow() {
    float freq = 0.1f;
    cnt++;

    int red = (int)(sin(freq * cnt + 0) * 127 + 128);
    int green = (int)(sin(freq * cnt + 2) * 127 + 128);
    int blue = (int)(sin(freq * cnt + 4) * 127 + 128);

    return (red << 16) | (green << 8) | blue;
}

void Tunnel(int totalTime) {
    auto startTime = GetTickCount64();
    srand(time(0));
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000.0;
        if (elapsedTime >= totalTime) {
            break;
        }
        auto hdc = GetDC(nullptr);
        int stretchFactor = -100;
        StretchBlt(hdc, 0, 0, screenWidth, screenHeight, hdc, stretchFactor / 2, stretchFactor / 2, screenWidth - stretchFactor, screenHeight - stretchFactor, SRCCOPY);
        ReleaseDC(nullptr, hdc);
        Sleep(5);
    }
}

void Static(int totalTime) {
    auto startTime = GetTickCount64();
    srand(time(0));
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        auto hdc = GetDC(nullptr);
        BitBlt(hdc, 0, 0, screenWidth, screenHeight, hdc, (rand() % 25) - 12, (rand() % 25) - 12, SRCINVERT);
        ReleaseDC(nullptr, hdc);
    }
}

void RainbowSpam(int totalTime) {
    ULONGLONG startTime = GetTickCount64();
    srand(time(0));
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        auto hdc = GetDC(nullptr);
        int x = rand() % screenWidth;
        int y = rand() % screenHeight;
        int size = 200;
        HBRUSH brush = CreateSolidBrush(GetRainbow());
        SelectObject(hdc, brush);
        MaskBlt(hdc, x, y, size, size, hdc, x + rand() % 21 - 10, y + rand() % 21 - 10, 0, 0, 0, 0x00220326);
        StretchBlt(hdc, 0, 0, screenWidth, screenHeight, hdc, x / 2, y / 2, screenWidth - x, screenHeight - y, 0x005A0049);
        ReleaseDC(nullptr, hdc);
        Sleep(50);
    }
}

void IconSpam(int totalTime) {
    ULONGLONG startTime = GetTickCount64();
    srand(time(0));

    LPSTR icons[] = { // if opened with vsc it errors, ignore
        IDI_APPLICATION, IDI_ASTERISK, IDI_ERROR, IDI_EXCLAMATION, 
        IDI_HAND, IDI_INFORMATION, IDI_QUESTION, IDI_SHIELD, 
        IDI_WARNING, IDI_WINLOGO
    };

    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        auto hdc = GetDC(nullptr);
        int x = rand() % screenWidth;
        int y = rand() % screenHeight;

        DrawIcon(hdc, x, y, LoadIconA(nullptr, icons[rand() % 11]));
        ReleaseDC(nullptr, hdc);
    }
}

void ScreenSmear(int totalTime) {
    auto startTime = GetTickCount64();
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        auto hdc = GetDC(nullptr);
        int mult = 25;
        srand(time(0)); // updating randomness every 1 sec smears screen and not shakes it
        int x = -((rand() % mult + 1) - (mult / 2));
        int y = -((rand() % mult + 1) - (mult / 2));
        auto brush = CreateSolidBrush(GetRainbow());
        SelectObject(hdc, brush);
        StretchBlt(hdc, 0, 0, screenWidth, screenHeight, hdc, x / 2, y / 2, screenWidth - x, screenHeight - y, 0x00CC0020);
        ReleaseDC(nullptr, hdc);
    }
}

void ScreenShake(int totalTime) {
    auto startTime = GetTickCount64();
    srand(time(0));
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        auto hdc = GetDC(nullptr);
        int mult = 25;
        int x = -((rand() % mult + 1) - (mult / 2));
        int y = -((rand() % mult + 1) - (mult / 2));
        auto brush = CreateSolidBrush(GetRainbow());
        SelectObject(hdc, brush);
        StretchBlt(hdc, 0, 0, screenWidth, screenHeight, hdc, x/2, y/2, screenWidth - x, screenHeight - y, 0x00CC0020);
        ReleaseDC(nullptr, hdc);
    }
}

void DvDBall(int size, int totalTime) {
    int screenWidth = GetSystemMetrics(SM_CXSCREEN) - size;
    int screenHeight = GetSystemMetrics(SM_CYSCREEN) - size;
    srand(time(0));
    int x = rand() % screenWidth;
    double y = rand() % screenHeight;
    bool hitTops = false;
    bool hitSide = false;
    bool switchTops = false;
    bool switchSides = false;
    auto startTime = GetTickCount64();
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }

        auto hdc = GetDC(nullptr);
        if (!switchSides) {
            if (x >= screenWidth) {
                hitSide = !hitSide;
                switchSides = !switchSides;
            }
        }
        else {
            if (x <= 0) {
                hitSide = !hitSide;
                switchSides = !switchSides;
            }
        }
        if (!switchTops) {
            if (y >= screenHeight) {
                hitTops = !hitTops;
                switchTops = !switchTops;
            }
        }
        else {
            if (y <= 0) {
                hitTops = !hitTops;
                switchTops = !switchTops;
            }
        }
        int moveFreq = 25;
        if (!hitTops)
            y += moveFreq;
        if (hitTops)
            y -= moveFreq;
        if (!hitSide)
            x += moveFreq;
        if (hitSide)
            x -= moveFreq;

        auto brush = CreateSolidBrush(GetRainbow());
        SelectObject(hdc, brush);
        Ellipse(hdc, x, static_cast<int>(y), size + x, size + static_cast<int>(y));
        ReleaseDC(nullptr, hdc);
        Sleep(10);
    }
}

void DvDText(LPCSTR customText, int totalTime) {
    int x = screenWidth / 2;
    double y = (screenHeight / 2) + 500;
    bool hitTops = false;
    bool hitSide = false;
    bool switchTops = false;
    bool switchSides = false;
    auto startTime = GetTickCount64();
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }

        auto hdc = GetDC(nullptr);
        if (!switchSides) {
            if (x >= screenWidth) {
                hitSide = !hitSide;
                switchSides = !switchSides;
            }
        }
        else {
            if (x <= 0) {
                hitSide = !hitSide;
                switchSides = !switchSides;
            }
        }
        if (!switchTops) {
            if (y >= screenHeight) {
                hitTops = !hitTops;
                switchTops = !switchTops;
            }
        }
        else {
            if (y <= 0) {
                hitTops = !hitTops;
                switchTops = !switchTops;
            }
        }
        int moveFreq = 25;
        if (!hitTops)
            y += moveFreq;
        if (hitTops)
            y -= moveFreq;
        if (!hitSide)
            x += moveFreq;
        if (hitSide)
            x -= moveFreq;

        SetTextColor(hdc, RGB(rand() % 256, rand() % 256, rand() % 256));
        TextOutA(hdc, x, y, customText, strlen(customText));
        ReleaseDC(nullptr, hdc);
        Sleep(10);
    }
}

void GrowingSquares(int totalTime) {
    auto startTime = GetTickCount64();
    srand(time(0));
    while (true) {
        auto hdc = GetDC(nullptr);
        int x = rand() % screenWidth;
        int y = rand() % screenHeight;
        int size = 100;

        for (int i = 0; i < 10; ++i) {
            BitBlt(hdc, x, y, size, size, hdc, x + rand() % 21 - 10, y + rand() % 21 - 10, (int)(SRCINVERT | NOTSRCCOPY));

            size += 50;
            x -= 25;
            y -= 25;
            Sleep(10);
        }
        ReleaseDC(nullptr, hdc);

        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        Sleep(500);
    }
}

void InvertSquares(int totalTime) {
    auto startTime = GetTickCount64();
    srand(time(0));
    while (true) {
        auto hdc = GetDC(nullptr);
        int x = rand() % screenWidth;
        int y = rand() % screenHeight;

        BitBlt(hdc, x, y, 500, 500, hdc, x + rand() % 21 - 10, y + rand() % 21 - 10, (int)(SRCINVERT | NOTSRCCOPY));
        ReleaseDC(nullptr, hdc);

        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        Sleep(50);
    }
}

void InvertSpam(int totalTime) {
    auto startTime = GetTickCount64();
    srand(time(0));
    while (true) {
        auto hdc = GetDC(nullptr);

        BitBlt(hdc, 0, 0, screenWidth, screenHeight, hdc, 0, 0, (int)(SRCINVERT | NOTSRCCOPY));
        ReleaseDC(nullptr, hdc);

        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }
        Sleep(50);
    }
}

void RunawayScreen(double speed, int totalTime) {
    auto startTime = GetTickCount64();
    
    while (true) {
        auto currentTime = GetTickCount64();
        auto elapsedTime = (currentTime - startTime) / 1000;
        if (elapsedTime >= totalTime) {
            break;
        }

        HDC hdc = GetDC(0);
        HDC hdcMem = CreateCompatibleDC(hdc);
        HBITMAP hbm = CreateCompatibleBitmap(hdc, screenWidth, screenHeight);
        SelectObject(hdcMem, hbm);

        BitBlt(hdcMem, 0, 0, screenWidth, screenHeight, hdc, 0, 0, SRCCOPY);
        BitBlt(hdc, 0, 0, screenWidth, screenHeight, NULL, 0, 0, BLACKNESS);

        for (int i = -1; i <= 1; i++) {
            for (int j = -1; j <= 1; j++) {
                BitBlt(hdc,
                    (i * screenWidth) + speed,
                    (j * screenHeight) + speed,
                    screenWidth, screenHeight,
                    hdcMem,
                    0, 0,
                    SRCCOPY);
            }
        }

        DeleteObject(hbm);
        DeleteDC(hdcMem);
        ReleaseDC(NULL, hdc);

        Sleep(10);
    }
}

DWORD WINAPI RainbowShader(LPVOID lpParam) {
    _RGBQUAD* data = new _RGBQUAD[screenWidth * screenHeight + screenWidth]; // init rgb array

    for (int j = 0;; j++, j %= 3) {

        HDC desk = GetDC(NULL);
        HDC hdcdc = CreateCompatibleDC(desk);
        HBITMAP hbm = CreateBitmap(screenWidth, screenHeight, 1, 32, data);
        SelectObject(hdcdc, hbm);
        BitBlt(hdcdc, 0, 0, screenWidth, screenHeight, desk, 0, 0, SRCCOPY);

        GetBitmapBits(hbm, screenWidth * screenHeight * 4, data);

        int cc = 1;
        for (int i = 0; i < screenWidth * screenHeight; i++) {
            // Do some math
            int x = i + screenWidth;
            int y = i + screenHeight;
            int total = (x / y) | 50000;
            data[i].rgb -= total;
            cc += 5;
        }
        SetBitmapBits(hbm, screenWidth * screenHeight * 4, data);
        BitBlt(desk, 0, 0, screenWidth, screenHeight, hdcdc, 0, 0, SRCCOPY);
        DeleteObject(hbm);
        DeleteObject(hdcdc);
        DeleteObject(desk);
        Sleep(1);
    }
    return 0;
}

DWORD WINAPI FractalShader(LPVOID lpParam) {
    _RGBQUAD* data = new _RGBQUAD[screenWidth * screenHeight + screenWidth];

    for (int j = 0;; j++, j %= 3) {

        HDC desk = GetDC(NULL);
        HDC hdcdc = CreateCompatibleDC(desk);
        HBITMAP hbm = CreateBitmap(screenWidth, screenHeight, 1, 32, data);
        SelectObject(hdcdc, hbm);
        BitBlt(hdcdc, 0, 0, screenWidth, screenHeight, desk, 0, 0, SRCCOPY);

        GetBitmapBits(hbm, screenWidth * screenHeight * 4, data);

        int cc = 1000;
        for (int i = 0; i < screenWidth * screenHeight; i++) {

            int total = ((i*2) & (i / screenHeight)) | cc;
            data[i].rgb -= total;
            cc = cc % 200;
        }
        SetBitmapBits(hbm, screenWidth * screenHeight * 4, data);
        BitBlt(desk, 0, 0, screenWidth, screenHeight, hdcdc, 0, 0, SRCCOPY);
        DeleteObject(hbm);
        DeleteObject(hdcdc);
        DeleteObject(desk);
    }
    return 0;
}

DWORD WINAPI SquareFractalShader(LPVOID lpParam) {
    COLOR* data = (COLOR*)VirtualAlloc(0, (screenWidth * screenHeight + screenWidth) * sizeof(COLOR), MEM_COMMIT, PAGE_READWRITE);
    HDC hdc = GetDC(0);
    HDC mdc = CreateCompatibleDC(hdc);
    HBITMAP bmp = CreateBitmap(screenWidth, screenHeight, 1, 32, data);
    SelectObject(mdc, bmp);

    while (true) {
        BitBlt(mdc, 0, 0, screenWidth, screenHeight, hdc, 0, 0, SRCCOPY);
        GetBitmapBits(bmp, screenWidth * screenHeight * sizeof(COLOR), data);

        for (int x2 = 0; x2 < screenWidth; x2++) {
            for (int y2 = 0; y2 < screenHeight; y2++) {
                int wave = ((x2 * y2) | (x2 * y2)) % 512;

                data[y2 * screenWidth + x2].rgb += wave;
            }
        }

        SetBitmapBits(bmp, screenWidth * screenHeight * sizeof(COLOR), data);
        BitBlt(hdc, 0, 0, screenWidth, screenHeight, mdc, 0, 0, SRCCOPY);

        Sleep(10);
    }
}

int main()
{
    ::ShowWindow(::GetConsoleWindow(), SW_HIDE); // Hide console
#if BLOCKINPUT
    BlockInput(true);
#endif
    int timeInBetween = 1 * 1000;
#if CLEAR_SCRN
    SendMessage(FindWindow("Shell_TrayWnd", NULL), WM_COMMAND, 419, 0); // Win + D
    // Incase a smaller ratio app was open
    screenWidth = GetSystemMetrics(SM_CXSCREEN);
    screenHeight = GetSystemMetrics(SM_CYSCREEN);
#endif

#if KILL_WALLS
    system("taskkill /F /T /IM wallpaper32.exe"); // Causes screen updates, ruins effects
#endif

    //METHODSHERE

    // Return computer back to normal
#if BLOCKINPUT
    BlockInput(false); 
#endif
#if CLEAR_SCRN
    SendMessage(FindWindow("Shell_TrayWnd", NULL), WM_COMMAND, 416, 0); // Win + D
#endif

    return 0;
}