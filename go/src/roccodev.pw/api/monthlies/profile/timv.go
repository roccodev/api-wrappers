package profile

import (
	"encoding/json"
	"fmt"
)

type TimvMonthlyProfile struct {
	MonthlyProfile
	MostChange      string `json:"most_change"`
	DetectivePoints int    `json:"d_points"`
	TraitorPoints   int    `json:"t_points"`
	InnocentPoints  int    `json:"i_points"`
}

func (prof *TimvMonthlyProfile) getFromRaw(data []byte) {
	e := json.Unmarshal(data, prof)
	if e != nil {
		fmt.Printf("Error occurred while parsing JSON: %s", e.Error())
	}
}

func (prof *TimvMonthlyProfile) Get(uuid string) {
	body := downloadJson("https://api.rocco.dev/TIMV/monthlies/profile/" + uuid)
	prof.getFromRaw(body)
}
