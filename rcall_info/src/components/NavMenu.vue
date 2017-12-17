<template>
    <div class="navbar-default sidebar" role="navigation">
        <div class="sidebar-nav navbar-collapse">
            <ul class="nav" id="side-menu">
                <li v-for="item in itemsMenu">
                    <router-link v-if=!item.haveChild :to="item.link" class="hvr-bounce-to-right">
                        <i :class="'fa nav_icon ' + item.icon" v-if=!item.isImage />
                        <img class="nav_icon" :src="item.image" v-if=item.isImage />
                        <span class="nav-label">{{ item.text }}</span>
                    </router-link>
                    <a v-if=item.haveChild @click="toggle(item)" class="hvr-bounce-to-right a-have-child">
                        <i :class="'fa nav_icon ' + item.icon" v-if=!item.isImage />
                        <img class="nav_icon" :src="item.image" v-if=item.isImage />
                        <span class="nav-label">{{ item.text }}</span>
                        <span v-if=item.haveChild class="fa arrow-menu" v-bind:class="{ 'fa-angle-down': item.open, 'fa-angle-left': !item.open }"></span>
                    </a>
                    <transition name="fade">
                        <ul v-if=item.haveChild v-show=item.open class="nav nav-second-level">
                            <li v-for="childitem in item.childItems">
                                <router-link v-if=!childitem.haveChild :to="childitem.link" class="hvr-bounce-to-right">
                                    <i :class="'fa nav_icon item-menu-child' + childitem.icon" v-if=!childitem.isImage />
                                    <img class="nav_icon item-menu-child" :src="childitem.image" v-if=childitem.isImage />
                                    <span class="nav-label">{{ childitem.text }}</span>
                                </router-link>
                                <a v-if=childitem.haveChild @click="toggle(childitem)" class="hvr-bounce-to-right a-have-child">
                                    <i :class="'fa nav_icon item-menu-child ' + childitem.icon" v-if=!childitem.isImage />
                                    <img class="nav_icon item-menu-child" :src="childitem.image" v-if=childitem.isImage />
                                    <span class="nav-label">{{ childitem.text }}</span>
                                    <span v-if=childitem.haveChild class="fa arrow-menu" v-bind:class="{ 'fa-angle-down': childitem.open, 'fa-angle-left': !childitem.open }"></span>
                                </a>
                                <transition name="fade">
                                    <ul v-if=childitem.haveChild v-show=childitem.open class="nav nav-second-level">
                                        <li v-for="ChildChildItem in childitem.childItems">
                                            <router-link v-if=!ChildChildItem.haveChild :to="ChildChildItem.link" class="hvr-bounce-to-right">
                                                <i :class="'fa nav_icon item-menu-child-two ' + ChildChildItem.icon" v-if=!ChildChildItem.isImage />
                                                <img class="nav_icon item-menu-child-two" :src="ChildChildItem.image" v-if=ChildChildItem.isImage />
                                                <span class="nav-label">{{ ChildChildItem.text }}</span>
                                            </router-link>                                            
                                        </li>
                                    </ul>
                                </transition>
                            </li>
                        </ul>
                    </transition>
                </li>
            </ul>
        </div>
    </div>
</template>
<script>
    export default {
        name: 'StartMenu',
        data() {
            return {
                itemsMenu: []
            }
        },
        props: {
            ph: {
                type: String,
                default: ''
            }
        },
        created() {
            this.fetchData()
        },
        watch: {
            '$route.params.id': 'fetchData'
        },
        methods: {
            fetchData() {
                var pathGet = this.$route.params.id != undefined ? this.$route.params.id : "start";
                this.$http.get('/api/' + pathGet).then((res) => {
                    this.itemsMenu = res.body.itemsMenu
                }).catch((ex) => console.log(ex))
            },
            toggle: function (item) {
                if (item.haveChild) {
                    item.open = !item.open;
                }
            },
        }
    }
</script>
