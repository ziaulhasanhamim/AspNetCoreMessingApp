var app = new Vue({
    el: '#app',
    data: {
        message: 'Hello Vue!',
        users: [],
        active_index: 0
    },
    async beforeCreate() {
        var res = await fetch("/api/user/")
        var data = await res.json()
        this.users = data;
    },
    methods: {
        change_active(index) {
            this.active_index = index;
        }
    }
});
