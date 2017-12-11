﻿using Newtonsoft.Json;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace Telegram.Bot.Requests
{
    /// <summary>
    /// Send point on the map
    /// </summary>
    public class SendLocationRequest : RequestBase<Message>
    {
        /// <summary>
        /// Unique identifier for the target chat or username of the target channel
        /// </summary>
        public ChatId ChatId { get; set; }

        /// <summary>
        /// Latitude of the location
        /// </summary>
        public float Latitude { get; set; }

        /// <summary>
        /// Longitude of the location
        /// </summary>
        public float Longitude { get; set; }

        /// <summary>
        /// Period in seconds for which the location will be updated, should be between 60 and 86400
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int LivePeriod { get; set; }

        /// <summary>
        /// Sends the message silently. Users will receive a notification with no sound.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableNotification { get; set; }

        /// <summary>
        /// If the message is a reply, ID of the original message
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ReplyToMessageId { get; set; }

        /// <summary>
        /// Additional interface options. A JSON-serialized object for a custom reply keyboard, instructions to hide keyboard or to force a reply from the user.
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IReplyMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Initializes a new request
        /// </summary>
        public SendLocationRequest()
            : base("sendLocation")
        { }

        /// <summary>
        /// Initializes a new request with chatId and location
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel</param>
        /// <param name="latitude">Latitude of the location</param>
        /// <param name="longitude">Longitude of the location</param>
        public SendLocationRequest(ChatId chatId, float latitude, float longitude)
            : this()
        {
            ChatId = chatId;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}