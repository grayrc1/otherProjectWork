// Dll_Example.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <utility>
#include <limits.h>
#include <stdio.h>
#include <string.h>
#include "Dll_Example.h"

int func_dll(
	int                an_int,
	char*              string_filled_in_dll,
	struct STRUCT_DLL* struct_dll
) 
{

	int i;

	printf("\n");
	printf("func_dll called\n");
	printf("---------------\n");
	printf("  an_int=%d\n", an_int);

	strcpy_s(string_filled_in_dll, sizeof string_filled_in_dll, "String filled in DLL");

	printf("  count_int=%d: ", struct_dll->count_int);
	for (i = 0; i<struct_dll->count_int; i++) {
		printf("  %d", struct_dll->ints[i]);
	}
	printf("\n");


	printf("\nreturning from func_dll\n");
	printf("-----------------------\n\n\n");

	return 2 * an_int;
}