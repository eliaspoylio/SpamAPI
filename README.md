# API for spam mail database

I'm collecting junk mail data for future purposes. This is the source code for the API serving some part of that data.

One future purpose for the API could be f.ex. to serve as a tool for training a neural network for spam detection. There's some "finnish" spamming included so there's a certain lingual aspect to this.


| Endpoint     | Description |
| ----------------------- | ------ |
|`GET: api/Messages`| Returns all messages |
|`GET: api/Messages/{id}`| Returns message with given id |
|`GET: api/Messages/size`| Returns the number of items in the messages table |