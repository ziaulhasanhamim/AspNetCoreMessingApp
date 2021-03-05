var app = new Vue({
    el: '#app',
    data: {
        messages: [],
        users: [],
        active_index: 0,
        connection: new signalR.HubConnectionBuilder().withUrl("/chatHub").build()
    },
    async mounted() {
        var userRes = await fetch("/api/user/")
        var userData = await userRes.json();
        this.users = userData;
        var messageRes = await fetch("/api/messages/");
        var messageData = await messageRes.json();
        this.messages = messageData;
        //this.connection.start().then(function () {
        //}).catch(function (err) {
        //    return console.error(err.toString());
        //});
    },
    methods: {
        change_active(index) {
            this.active_index = index;
        }
    }
});
