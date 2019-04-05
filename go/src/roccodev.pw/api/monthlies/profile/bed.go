package profile

import (
	"encoding/json"
	"fmt"
)

type BedMonthlyProfile struct {
	pvpMonthlyProfile
	Beds  int
	Teams int
}

func (prof *BedMonthlyProfile) getFromRaw(data []byte) {
	e := json.Unmarshal(data, prof)
	if e != nil {
		fmt.Printf("Error occurred while parsing JSON: %s", e.Error())
	}
}

func (prof *BedMonthlyProfile) Get(uuid string) {
	body := downloadJson("https://api.rocco.dev/BED/monthlies/profile/" + uuid)
	prof.getFromRaw(body)
}
