const express = require('express')
const bodyParser = require('body-parser')
const app = express()
const port = 3000

var jsonParser = bodyParser.json()
var urlencodedParser = bodyParser.urlencoded({ extended: false })

var dogs = [
    {
        id: 1,
        name: "Psiok"
    },
]

app.get('/', (req, res) => {
    res.json(dogs)
})

app.post('/', urlencodedParser, (req, res) => {
    const name = req.body.name
    dogs.push({id: dogs.length+1, name: name})
    res.json(dogs)
})

app.put('/:id', urlencodedParser, (req, res) => {
    const id = req.params.id
    const name = req.body.name
    const dogIndex = dogs.findIndex((doggo) => doggo.id == Number(id))
    // if(id && name && dogIndex){
        console.log(dogs[dogIndex])
        dogs[dogIndex] = {id: id, name: name}
    // }
    res.json(dogs)
})

app.listen(port, () => {
    console.log(`App running at: http://localhost:${port}`)
})