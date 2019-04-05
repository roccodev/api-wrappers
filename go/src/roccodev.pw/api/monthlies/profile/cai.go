package profile

import (
	"encoding/json"
	"fmt"
)

type CaiMonthlyProfile struct {
	MonthlyProfile
	Captures int
	Caught   int
}

func (prof *CaiMonthlyProfile) getFromRaw(data []byte) {
	e := json.Unmarshal(data, prof)
	if e != nil {
		fmt.Printf("Error occurred while parsing JSON: %s", e.Error())
	}
}

func (prof *CaiMonthlyProfile) Get(uuid string) {
	body := downloadJson("https://api.rocco.dev/CAI/monthlies/profile/" + uuid)
	prof.getFromRaw(body)
}
