#pragma once

#ifdef DLLEXAMPLE_EXPORTS
#define DLLEXAMPLE_API __declspec(dllexport)
#else
#define DLLEXAMPLE_API __declspec(dllimport)
#endif

struct STRUCT_DLL {
	int  count_int;
	int* ints;
};

int func_dll(
	int                an_int,
	char*              string_filled_in_dll,
	struct STRUCT_DLL* struct_dll
);