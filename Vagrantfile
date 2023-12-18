Vagrant.configure("2") do |config|
  config.vm.box = "centos/7"
  config.vm.network "forwarded_port", guest: 5000, host: 5050
  config.vm.network "forwarded_port", guest: 8889, host: 8899
  config.vm.synced_folder ".", "/vagrant", type: "rsync"
  config.vm.provision :shell, path: "./install.sh"
end
