Vue.component('my-component', {
    template: '<div><img :src="message" alt="quad" /><br /><button v-on:click="DoIT"> выполнить</button></div>',
    data: function () {
        return {
            message: '/images/quad.svg'
        }        
    },
    methods: {
        DoIT: function (event) {
            var vm = this
            axios.get('/Start/GetData')
                .then(function (response) {
                    console.log(response);
                    vm.message = response.data.abrvalc;
                })
                .catch(function (error) {
                    console.log(error);
                });

        }
    }
})

const Start = '<div class="navbar-default sidebar" role="navigation" ><div class="sidebar-nav navbar-collapse" ><ul class="nav" id="side-menu"><li v-for="item in items"><router-link to="/home" class="hvr-bounce-to-right"><img class="nav_icon " src="/images/quad.svg" /><span class="nav-label">{{ item.text }}</span></router-link></li></ul></div></div>'
const About = '<p>о нас</p>'
const routes = {
    '/': Start,
    '/home': About
}


Vue.component('my-side-nav-menu-component', {
    template: routes[window.location.pathname] || Start,
    data: function () {
        return {
            items: [],
            currentRoute: window.location.pathname
        }
    },
    created() {
        this.fetchData()
    },
    methods: {
        fetchData() {
            var vm = this
            axios.get('/Start/GetData')
                .then(function (response) {
                    console.log(response);
                    vm.items = response.data.items;
                })
                .catch(function (error) {
                    console.log(error);
                });

        }
    }

})


new Vue({
    el: '#app'
    
});




 var sideMenu = new Vue({
    el: '#my-side-nav-menu'
})