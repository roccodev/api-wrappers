package profile

import (
	"fmt"
	"io/ioutil"
	"net/http"
)

func downloadJson(url string) []byte {
	res, e := http.Get(url)
	if e != nil {
		fmt.Printf("Error occurred while downloading data: %s", e.Error())
	}

	body, err := ioutil.ReadAll(res.Body)

	if err != nil {
		fmt.Printf("Error occurred while parsing body: %s", err.Error())
	}

	return []byte(string(body))

}
