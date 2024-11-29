package dictionaryAndTuple

import "fmt"

//There is Dictionary and tupes as C# in go lang, but here is way using Map & Struct in Go to
//Simulate those in go

type SimulateDictionaryTuple interface {
	SimulateDictionaryAndTuple()
}

// Define a struct to hold the languages for a book
type Languages struct {
	Language1 string
	Language2 string
	Language3 string
}

func SimulateDictionaryAndTuple() {
	// Declare a map with book names as keys and Languages structs as values
	books := map[string]Languages{
		"DataStructure": {"Java", "C#", "JavaScript"},
		"BhagwatGeeta":  {"English", "Hindi", "Sanskrit"},
	}
	// Print the data
	for book, languages := range books {
		fmt.Printf("BookName: %s, Languages: %s, %s, %s\n",
			book, languages.Language1, languages.Language2, languages.Language3)
	}
}
