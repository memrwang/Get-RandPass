//
//  AppDelegate.swift
//  Get RandPass
//
//  Created by along on 2023/7/28.
//

import Cocoa

@main
class AppDelegate: NSObject, NSApplicationDelegate {

    @IBOutlet var window: NSWindow!

    
    @IBOutlet weak var PassTextField: NSTextField!
    
    @IBOutlet weak var UppercasesCheckbox: NSButton!
    
    @IBOutlet weak var LowercasesCheckbox: NSButton!
    
    @IBOutlet weak var NumbersCheckbox: NSButton!

    @IBOutlet weak var SymbolsCheckbox: NSButton!
    
    @IBOutlet weak var LengthTextField: NSTextField!
    
    @IBOutlet weak var IgnoredTextField: NSTextField!
    
    
    @IBOutlet weak var PassLabel: NSTextField!
    
    @IBOutlet weak var SuccesLabel: NSTextField!
    
    @IBOutlet weak var LengthLabel: NSTextField!
    
    @IBOutlet weak var IgnoredLabel: NSTextField!
    
    
    var timer: Timer?
    
    func applicationDidFinishLaunching(_ aNotification: Notification) {
        // Insert code here to initialize your application
        
        // 设置窗口背景颜色为白色
        window.backgroundColor = NSColor(red: 0.16, green: 0.16, blue: 0.16, alpha: 1.0)
        
        // 定义忽略字符
        IgnoredTextField.stringValue = "1iIl0oO"
        // 隐藏成功标签
        SuccesLabel.isHidden = true

    }

    func applicationWillTerminate(_ aNotification: Notification) {
        // Insert code here to tear down your application
    }

    func applicationSupportsSecureRestorableState(_ app: NSApplication) -> Bool {
        return true
    }
    
    func applicationShouldTerminateAfterLastWindowClosed(_ sender: NSApplication) -> Bool {
        return true
    }
    
    // 复制按钮
    @IBAction func CopyButton_Click(_ sender: Any) {
        let pasteboard = NSPasteboard.general
        pasteboard.clearContents()
        pasteboard.setString(PassTextField.stringValue, forType: .string)
        
        // 显示成功标签
        SuccesLabel.isHidden = false
        SuccesStartTimer()
        
    }
    
    // 显示成功标签
    func SuccesStartTimer() {
        // 创建一个定时器，0.5秒后触发一次
        timer = Timer.scheduledTimer(timeInterval: 0.5, target: self, selector: #selector(SuccesHideLabel), userInfo: nil, repeats: false)
    }
    
    // 隐藏成功标签
    @objc func SuccesHideLabel() {
        SuccesLabel.isHidden = true
    }
    
    // 生成按钮
    @IBAction func GetButton_Click(_ sender: Any) {
        // 字符包含类型
        var includeUppercase = false
        var includeLowercase = false
        var includeNumbers = false
        var includeSymbols = false
        let Length = Int(LengthTextField.stringValue)!
        let Ignored = IgnoredTextField.stringValue
        
        if UppercasesCheckbox.state == .on{
            includeUppercase = true
        }
        if LowercasesCheckbox.state == .on{
            includeLowercase = true
        }
        if NumbersCheckbox.state == .on{
            includeNumbers = true
        }
        if SymbolsCheckbox.state == .on{
            includeSymbols = true
        }
        
        // 获取生成的密码
        let password = generateRandomPassword(length: Length, includeUppercase: includeUppercase, includeLowercase: includeLowercase, includeNumbers: includeNumbers, includeSymbols: includeSymbols, ignoreCharacters: Ignored)
        PassTextField.stringValue = password
    }
    
    // 生成随机密码
    func generateRandomPassword(length: Int, includeUppercase: Bool, includeLowercase: Bool, includeNumbers: Bool, includeSymbols: Bool, ignoreCharacters: String) -> String {
        // 定义字符
        let uppercaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        let lowercaseLetters = "abcdefghijklmnopqrstuvwxyz"
        let numbers = "0123456789"
        let symbols = "!@#$%&*"
        
        var allowedCharacters = ""
        
        if includeUppercase {
            allowedCharacters += uppercaseLetters
        }
        
        if includeLowercase {
            allowedCharacters += lowercaseLetters
        }
        
        if includeNumbers {
            allowedCharacters += numbers
        }
        
        if includeSymbols {
            allowedCharacters += symbols
        }
        
        let ignoredCharacterSet = CharacterSet(charactersIn: ignoreCharacters)
        let filteredCharacters = allowedCharacters.filter { !ignoredCharacterSet.contains($0.unicodeScalars.first!) }
            
        var password = ""
        
        repeat {
            password = ""
            for _ in 0..<length {
                let randomIndex = filteredCharacters.index(filteredCharacters.startIndex, offsetBy: Int(arc4random_uniform(UInt32(filteredCharacters.count))))
                    let randomCharacter = filteredCharacters[randomIndex]
                    password.append(randomCharacter)
            }
        } while (includeUppercase && !password.contains(where: { uppercaseLetters.contains($0) })) ||
                    (includeNumbers && !password.contains(where: { numbers.contains($0) })) ||
                    (includeSymbols && !password.contains(where: { symbols.contains($0) }))
        return password
    }
    
    // 官网
    @IBAction func WebsiteClick(_ sender: Any) {
        if let url = URL(string: "http://ialong.cn") {
            NSWorkspace.shared.open(url)
        }
    }
}
