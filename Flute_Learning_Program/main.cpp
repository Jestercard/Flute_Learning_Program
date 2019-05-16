#include <windows.h>
#include <stdlib.h>

#define FILE_MENU_NEW 1
#define FILE_MENU_OPEN 2
#define FILE_MENU_EXIT 3
#define GENERATE_BUTTON 4

LRESULT CALLBACK WindowProcedure(HWND, UINT, WPARAM, LPARAM);

void AddControls(HWND);

int WINAPI WinMain(HINSTANCE hInst, HINSTANCE hPrevInst, LPTSTR args, int ncmdshow)
{
    WNDCLASSW wc = {0};

    wc.hbrBackground = (HBRUSH) COLOR_WINDOW ;
    wc.hCursor = LoadCursor(NULL, IDC_ARROW);
    wc.hInstance = hInst;
    wc.lpszClassName = L"myWindowClass";
    wc.lpfnWndProc = WindowProcedure;

    if(!RegisterClassW(&wc))
        return -1;

    CreateWindowW(L"myWindowClass", L"Flute Learning Program", WS_OVERLAPPEDWINDOW | WS_VISIBLE, 100, 100, 720, 480,
                  NULL, NULL, NULL, NULL);
    MSG msg = {0};

    while( GetMessage(&msg, NULL, NULL, NULL ))
    {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }

    return 0;
}

LRESULT CALLBACK WindowProcedure(HWND hWnd, UINT msg, WPARAM wp, LPARAM lp)
{
    switch ( msg)
    {
    case WM_COMMAND:

        switch(wp)
        {
        case FILE_MENU_EXIT:
            DestroyWindow(hWnd);
            break;
        }
        break;
    case WM_CREATE:
        AddControls(hWnd);
        break;
    case WM_DESTROY:
        PostQuitMessage(0);
        break;
    default:
        return DefWindowProcW(hWnd, msg, wp, lp);
    }
}

void AddControls(HWND hWnd)
{
    ;
}

//THIS IS THE TITS JESSE
//Yeah it is
