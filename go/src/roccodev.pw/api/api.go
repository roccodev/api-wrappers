package main

import "roccodev.pw/api/monthlies/profile"
import "fmt"

func main() {
	prof := profile.BedMonthlyProfile{}
	prof.Get("e891f022633a4bf28f4030493fda9bbb")
	fmt.Println(prof.Kills)
}
