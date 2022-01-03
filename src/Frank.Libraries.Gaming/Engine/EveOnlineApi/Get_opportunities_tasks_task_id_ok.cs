namespace EveOnlineApi;

    /// <summary>
    /// 200 ok object
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.5.0 (NJsonSchema v10.6.6.0 (Newtonsoft.Json v9.0.0.0))")]
    public record Get_opportunities_tasks_task_id_ok
    {
        [System.Text.Json.Serialization.JsonConstructor]

        public Get_opportunities_tasks_task_id_ok(string @description, string @name, string @notification, int @task_id)

        {

            this.Description = @description;

            this.Name = @name;

            this.Notification = @notification;

            this.Task_id = @task_id;

        }    /// <summary>
        /// description string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; init; }

        /// <summary>
        /// notification string
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("notification")]
        public string Notification { get; init; }

        /// <summary>
        /// task_id integer
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int Task_id { get; init; }

    }
